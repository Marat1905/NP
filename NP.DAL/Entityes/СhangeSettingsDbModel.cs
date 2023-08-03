using NP.DAL.Entityes.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace NP.DAL.Entityes
{
    /// <summary>Таблица фиксирования изменений работы БДМ</summary>
    [Table("СhangeSettingsTable")]
    public class СhangeSettingsDbModel:Entity
    {
        /// <summary>Изменение задания веса бумажного полотна </summary>
        public double? SetpointPaperWeightChange { get; set; }

        /// <summary>Изменение ширины бумажного полотна </summary>
        public double? SetpointPaperFormatChange { get; set; }

        /// <summary>Изменение скорости БДМ </summary>
        public double? SetpointWireChange { get; set; }

        /// <summary>Время начала изменения</summary>
        public DateTime Start { get; set; }

        /// <summary>Время конца изменения</summary>
        public DateTime? End { get; set; }

        /// <summary>Расчетное время работы</summary>
        public TimeSpan? TimeRun { get; set; }

    }
}
