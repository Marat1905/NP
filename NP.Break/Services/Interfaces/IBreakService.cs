using NP.Break.Infrastructure.EventArgs;
using NP.Break.Models;
using NP.Infrastructure.Enums;
using System;
using System.Collections.Generic;

namespace NP.Break.Services.Interfaces
{
    public interface IBreakService
    {
        /// <summary>Сигнал обрыва с БДМ </summary>
        int BreakInt { get; set; }

        /// <summary>Сигнал что БДМ на рабочей скорости </summary>
        int RunBdm { get; set; }

        /// <summary>Данные по обрыву </summary>
        BreakInfo Break { get; set; }

        /// <summary>Коллекция обрывов</summary>
        IEnumerable<BreakInfo> Breaks { get;}

        /// <summary>Выборка за смену</summary>
        /// <param name="data">Дата</param>
        /// <param name="smena">Смена</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекция обрывов</returns>
        IEnumerable<BreakInfo> Smena(DateTime data,Smena smena,TimeSpan filter = new TimeSpan());

        /// <summary>Выборка за период </summary>
        /// <param name="start">Начальная дата поиска</param>
        /// <param name="end">Конечная дата поиска</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекция обрывов</returns>
        IEnumerable<BreakInfo> Period(DateTime start,DateTime end,TimeSpan filter=new TimeSpan());


        delegate void BreakHandler(BreakService sender, BreakEventArgs e);
        event BreakHandler? Notify;

    }
}
