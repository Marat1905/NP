using NP.Break.Infrastructure.EventArgs;
using NP.Break.Models;
using NP.Break.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Extensions;
using NP.DAL.Interfaces;
using NP.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NP.Break.Services
{
    public class BreakService : IBreakService
    {
       // private readonly NPDB db;

        private int _BreakInt;
        private readonly IRepository<BreakDbModel> _Db;

        public event IBreakService.BreakHandler? Notify;

        public int BreakInt 
        { 
            get => _BreakInt; 
            set
            {
                if(value!= _BreakInt)
                {
                    if (value == 1)
                    {
                        Notify?.Invoke(this, new BreakEventArgs(NotifyBreakChangedAction.Break, NewBreak(Break)));
                    }
                    else
                    {
                        Notify?.Invoke(this, new BreakEventArgs(NotifyBreakChangedAction.Ok, EndBreak()));
                    }                      
                    _BreakInt=value;
                }
            }             
        }
        public int RunBdm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BreakInfo Break { get; set; }

        /// <summary>Получаем все обрывы с БД </summary>
        public IEnumerable<BreakInfo> Breaks => BreakIenumerable(_Db.Items);

        /// <summary>Получаем все обрывы с БД за определенный период </summary>
        public IEnumerable<BreakInfo> Period<BreakInfo>(DateTime start, DateTime end, TimeSpan filter = default)
        {
            if(end<start)
                throw new ArgumentOutOfRangeException("Конечная дата поиска меньше либо равна начальной дате поиска");
            var result = _Db.Items.Where(x => x.EndBreak>=start && x.StartBreak<=end).ToList();
            return (IEnumerable<BreakInfo>)BreakIenumerable(result,start,end,filter);
        }

        /// <summary>
        /// Получаем обрывы если они были за определенную смену
        /// </summary>
        /// <param name="data">Дата</param>
        /// <param name="smena">Смена ночная или дневная</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекцию обрывов</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<BreakInfo> SmenaSearch<BreakInfo>(DateTime data, Smena smena, TimeSpan filter = default)
        {
            DateTime start;
            DateTime end;
            switch (smena)
            {
                case Smena.Day:
                    {
                        start = data.Date.Add(new TimeSpan(08, 00, 00));
                        end = data.Date.Add(new TimeSpan(20, 00, 00));
                        return Period<BreakInfo>(start, end, filter);
                    }
                    break;
                case Smena.Night:
                    {
                        start = data.Date.Add(new TimeSpan(20, 00, 00));
                        end = data.Date.Add(new TimeSpan(1,08, 00, 00));
                        return Period<BreakInfo>(start, end, filter);
                    }
                    break;
            }
           throw new Exception("Странное поведение");
        }


        public BreakService(IRepository<BreakDbModel> db)
        {
            this._Db = db;
            Break ??= new BreakInfo();
            var temp = _Db.Items.OrderBy(i => i.Id).LastOrDefault();
            if(temp != null)
            {
               if(temp.EndBreak == null)
                {
                    _BreakInt = 1;
                }
            }
        }

        private IEnumerable<BreakInfo> BreakIenumerable(IEnumerable<BreakDbModel> breaks)
        {
           foreach (var item in breaks) 
            {
                yield return item.ModelMapInfo<BreakDbModel, BreakInfo>();
            }
        }

        private IEnumerable<BreakInfo> BreakIenumerable(IEnumerable<BreakDbModel> breaks, DateTime start, DateTime end, TimeSpan filter = default)
        {
            foreach (var item in breaks)
            {
                BreakInfo result = (BreakInfo)item.ModelMapInfo<BreakDbModel, BreakInfo>().Clone();
                if(result.StartBreak <= start)
                    result.StartBreak = start; 
                if(result.EndBreak >= end)
                    result.EndBreak = end;
                result.TimeBreak = result.EndBreak - result.StartBreak;
                if(result.TimeBreak>filter)
                    yield return result;
            }
        }




        /// <summary>Запись нового обрыва </summary>
        private BreakInfo NewBreak(BreakInfo breakInfo)
        {
            BreakInfo result = (BreakInfo)breakInfo.Clone() ;
            result.StartBreak=DateTime.Now;
            var item = result.ModelMap<BreakInfo, BreakDbModel>();
            _Db.Add(item);
            return result;
        }
        /// <summary>Запись конца обрыва и расчет потраченного времени </summary>
        private BreakInfo? EndBreak()
        {
            var temp = _Db.Items.OrderBy(i=>i.Id).LastOrDefault();
            if (temp != null)
            {
                temp.EndBreak = DateTime.Now;
                temp.TimeBreak = temp.EndBreak - temp.StartBreak;
                _Db.Update(temp);

                return temp.ModelMapInfo<BreakDbModel, BreakInfo>();

            }
            return null;
        }
        
    }
}
