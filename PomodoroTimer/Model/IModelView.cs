using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal interface IModelView
    {
        bool TimerEnable { get; }
        DateTime Time { get; }
        int PomodoroCounter { get; }
    }
}
