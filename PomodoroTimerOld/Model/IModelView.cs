using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal interface IModelView
    {
        event Action<TimeSpan>? ChangeTime;
        event Action<bool>? ChangeTimerState;
        event Action<int>? ChangePomodoroCounter;
    }
}
