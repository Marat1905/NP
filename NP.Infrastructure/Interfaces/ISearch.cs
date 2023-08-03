using NP.Infrastructure.Enums;
using System;
using System.Collections.Generic;

namespace NP.Infrastructure.Interfaces
{
    /// <summary>Интерфейс поиска </summary>
    public interface ISearch
    {
        /// <summary>Выборка за смену</summary>
        /// <param name="data">Дата</param>
        /// <param name="smena">Смена</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекция </returns>
        IEnumerable<T> SmenaSearch<T>(DateTime data, Smena smena, TimeSpan filter = new TimeSpan());

        /// <summary>Выборка за период </summary>
        /// <param name="start">Начальная дата поиска</param>
        /// <param name="end">Конечная дата поиска</param>
        /// <param name="filter">Фильтр времени</param>
        /// <returns>Коллекция </returns>
        IEnumerable<T> Period<T>(DateTime start, DateTime end, TimeSpan filter = new TimeSpan());
    }
}
