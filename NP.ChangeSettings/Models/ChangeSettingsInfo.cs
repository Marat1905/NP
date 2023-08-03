namespace NP.ChangeSettings.Models
{
    /// <summary>Контроль изменений параметров работы БДМ </summary>
    internal class ChangeSettingsInfo : ICloneable
    {
        #region Свойства
        /// <summary>Идентификатор </summary>
        public int Id { get; set; }

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

        #endregion

        #region Конструкторы
        ///<inheritdoc cref="ChangeSettingsInfo"/>
        public ChangeSettingsInfo() { }

        /// <summary> <inheritdoc cref="ChangeSettingsInfo"/> </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="setpointPaperWeightChange">Изменение задания веса бумажного полотна</param>
        /// <param name="setpointPaperFormatChange">Изменение ширины бумажного полотна</param>
        /// <param name="setpointWireChange">Изменение скорости БДМ </param>
        /// <param name="start">Время начала изменения </param>
        /// <param name="end">Время конца изменения</param>
        public ChangeSettingsInfo(int id, double? setpointPaperWeightChange,
                                  double? setpointPaperFormatChange, double? setpointWireChange,
                                  DateTime start, DateTime? end)
        {
            Id = id;
            SetpointPaperWeightChange = setpointPaperWeightChange;
            SetpointPaperFormatChange = setpointPaperFormatChange;
            SetpointWireChange = setpointWireChange;
            Start = start;
            End = end;
            TimeRun = end-start;
        }
        #endregion

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
