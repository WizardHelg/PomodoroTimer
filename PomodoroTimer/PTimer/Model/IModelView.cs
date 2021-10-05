using System;

namespace PomodoroTimer.PTimer.Model
{
    internal interface IModelView
    {
        event Action<TimeSpan>? ChangeTime;
        event Action<int, int>? ChangePomodoroNumber;
    }
}
