using NP.Break.Models;

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
