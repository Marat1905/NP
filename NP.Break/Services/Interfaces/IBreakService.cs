using NP.Break.Infrastructure.EventArgs;
using NP.Break.Models;
using NP.Infrastructure.Enums;
using NP.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace NP.Break.Services.Interfaces
{
    public interface IBreakService:ISearch
    {
        /// <summary>Сигнал обрыва с БДМ </summary>
        int BreakInt { get; set; }

        /// <summary>Сигнал что БДМ на рабочей скорости </summary>
        int RunBdm { get; set; }

        /// <summary>Данные по обрыву </summary>
        BreakInfo Break { get; set; }

        /// <summary>Коллекция обрывов</summary>
        IEnumerable<BreakInfo> Breaks { get;}

        delegate void BreakHandler(BreakService sender, BreakEventArgs e);
        event BreakHandler? Notify;

    }
}
