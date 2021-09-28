using System;

namespace PomodoroTimer.Model
{
    internal interface IModelView
    {
        event Action<TimeSpan>? ChangeTime;
        event Action<int>? ChangePomodoroNumber;
    }
}
