using NP.Break.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Break.Infrastructure.EventArgs
{
    public class BreakEventArgs
    {
        
        public NotifyBreakChangedAction NotifyBreak { get; }
        
        public BreakInfo BreakInfo { get; }

        public BreakEventArgs(NotifyBreakChangedAction notifyBreak, BreakInfo breakInfo)
        {
            NotifyBreak = notifyBreak;
            BreakInfo = breakInfo;
        }
    }
}
