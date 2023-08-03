using NP.DAL.Entityes.Base;
using NP.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NP.DAL.Entityes
{
    /// <summary>Таблица контроля параметров перед обрывом и фиксирования время простоя</summary>
    [Table("BreaksTable")]
    public class BreakDbModel:Entity
    {
        /// <summary>Заданный вес бумажного полотна </summary>
        public double SetpointPaperWeight { get; set; }

        /// <summary>Фактический вес бумажного полотна </summary>
        public double ActualPaperWeight { get; set; }

        /// <summary>Заданная влажность бумажного полотна </summary>
        public double SetpointPaperMoisture { get; set; }

        /// <summary>Фактическая влажность бумажного полотна </summary>
        public double ActualPaperMoisture { get; set; }

        /// <summary>Фактическая скорость сетки</summary>
        public double WireSpeed { get; set; }

        /// <summary>Фактическая скорость наката</summary>
        public double ReleerSpeed { get; set; }

        /// <summary>Время начала обрыва</summary>
        public DateTime StartBreak { get; set; }

        /// <summary>Время конца обрыва</summary>
        public DateTime? EndBreak { get; set; }

        /// <summary>Время обрыва</summary>
        public TimeSpan? TimeBreak { get; set; }

        /// <summary>Место обрыва</summary>
        public BreakStatus Status { get; set; }
    }
}
