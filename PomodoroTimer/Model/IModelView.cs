using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal interface IModelView
    {
        event Action<DateTime>? ChangeTime;
        event Action<bool>? ChangeTimerState;
        event Action<int>? ChangePomodoroCounter;
    }
}
