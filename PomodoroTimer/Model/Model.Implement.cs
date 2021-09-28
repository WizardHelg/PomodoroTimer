using System;

namespace PomodoroTimer.Model
{
    internal partial class Model
    {
        public event Action<TimeSpan>? ChangeTime;
        public event Action<int>? ChangePomodoroNumber;

        public void Start() => timer.Start();

        public void Pause() => timer.Stop();

        public void Skip()
        {
            timer.Stop();

            if (steps.Count == 0)
                InitQueue();

            currentStep = steps.Dequeue();

            ChangeTime?.Invoke(currentStep);
            ChangePomodoroNumber?.Invoke(currentStep.Number);
        }

        public void Reset()
        {
            timer.Stop();
            
            InitQueue();
            currentStep = steps.Dequeue();

            ChangeTime?.Invoke(currentStep);
            ChangePomodoroNumber?.Invoke(currentStep.Number);
        }
    }
}
