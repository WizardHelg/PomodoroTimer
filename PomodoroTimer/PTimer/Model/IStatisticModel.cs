using System;

namespace PomodoroTimer.PTimer.Model
{
    internal interface IStatisticModel
    {
        event Action PomodoroComplited;
    }
}
