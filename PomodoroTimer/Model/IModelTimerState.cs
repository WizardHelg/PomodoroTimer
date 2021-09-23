using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal interface IModelTimerState
    {
        bool TimerEnable { get; set; }
        void Skip();
        void Reset();
    }
}
