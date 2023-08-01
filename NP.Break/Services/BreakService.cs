using NP.Break.Infrastructure.EventArgs;
using NP.Break.Models;
using NP.Break.Services.Interfaces;
using NP.DAL.Context;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;
using NP.Infrastructure.Enums;
using System;
using System.Collections.Generic;

namespace NP.Break.Services
{
    public class BreakService : IBreakService
    {
       // private readonly NPDB db;

        private int _BreakInt;
        private readonly IRepository<BreakDbModel> db;

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
                        NewBreak();
                        Notify?.Invoke(this, new BreakEventArgs(NotifyBreakChangedAction.Break, Break));
                    }
                    else
                    {
                        EndBreak();
                        Notify?.Invoke(this, new BreakEventArgs(NotifyBreakChangedAction.Ok, Break));
                    }                      
                    _BreakInt=value;
                }
            }             
        }
        public int RunBdm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BreakInfo Break { get; set; }

        /// <summary>Получаем все обрывы с БД </summary>
        public IEnumerable<BreakInfo> Breaks => throw new NotImplementedException();

        /// <summary>Получаем все обрывы с БД за определенный период </summary>
        public IEnumerable<BreakInfo> Period(DateTime start, DateTime end, TimeSpan filter = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получаем обрывы если они были за определенную смену
        /// </summary>
        /// <param name="data">Дата</param>
        /// <param name="smena">Смена ночная или дневная</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекцию обрывов</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<BreakInfo> Smena(DateTime data, Smena smena, TimeSpan filter = default)
        {
            throw new NotImplementedException();
        }


        public BreakService(IRepository<BreakDbModel> db)
        {
            this.db = db;
        }

       



        /// <summary>Запись нового обрыва </summary>
        private void NewBreak()
        {
            
        }
        /// <summary>Запись конца обрыва и расчет потраченного времени </summary>
        private void EndBreak()
        {

        }
        
    }
}
