using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
