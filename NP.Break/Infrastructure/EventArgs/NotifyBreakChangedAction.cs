namespace NP.Break.Infrastructure.EventArgs
{
    /// <summary>Перечисление для события об обрыве </summary>
    public enum NotifyBreakChangedAction
    {
        /// <summary>Обрыв на машине </summary>
        Break,
        /// <summary>БДМ заправилась</summary>
        Ok
    }
}
