using System;
using System.Windows.Forms;

namespace PomodoroTimer.PTimer.Model
{
    internal partial class Model
    {
        public event Action<TimeSpan>? ChangeTime;
        public event Action<int, int>? ChangePomodoroNumber;

        public void Start() => timer.Start();

        public void Pause() => timer.Stop();

        public void Skip() => Skip(skipAll: false);
        
        public void Reset() => Skip(skipAll: true);

        private void Skip(bool skipAll)
        {
            timer.Stop();

            if (steps.Count == 0 || skipAll)
                InitQueue();
            
            currentStep = steps.Dequeue();
            currentStepNumber++;

            ChangeTime?.Invoke(currentStep);
            ChangePomodoroNumber?.Invoke(currentStepNumber, maxStepNumber);
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
}
