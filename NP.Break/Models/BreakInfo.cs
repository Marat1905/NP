using NP.Infrastructure.Enums;
using System;

namespace NP.Break.Models
{
    /// <summary> Формирование обрыва </summary>
    public class BreakInfo:ICloneable
    {
        #region Свойства
        /// <summary>Идентификатор </summary>
        public int Id { get; set; }

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
        #endregion

        #region Конструкторы

        /// <summary> Формирование обрыва</summary>
        /// <param name="setpointPaperWeight">Заданный вес бумажного полотна</param>
        /// <param name="actualPaperWeight">Фактический вес бумажного полотна</param>
        /// <param name="setpointPaperMoisture">Заданная влажность бумажного полотна</param>
        /// <param name="actualPaperMoisture">Фактическая влажность бумажного полотна </param>
        /// <param name="wireSpeed">Фактическая скорость сетки</param>
        /// <param name="releerSpeed">Фактическая скорость наката</param>
        /// <param name="status">Место обрыва</param>
        public BreakInfo(double setpointPaperWeight,double actualPaperWeight,
                          double setpointPaperMoisture, double actualPaperMoisture,
                          double wireSpeed, double releerSpeed, BreakStatus status)
        {
            SetpointPaperWeight = setpointPaperWeight;
            ActualPaperWeight = actualPaperWeight;
            SetpointPaperMoisture = setpointPaperMoisture;
            ActualPaperMoisture = actualPaperMoisture;
            WireSpeed = wireSpeed;
            ReleerSpeed = releerSpeed;
            Status = status;
            StartBreak = DateTime.Now;
        }

        public BreakInfo() { }

        public object Clone()
        {
             return MemberwiseClone();
        }
        #endregion

    }
}
