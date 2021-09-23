using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer.Model
{
    internal partial class Model
    {
        public event Action<TimeSpan>? ChangeTime;
        public event Action<bool>? ChangeTimerState;
        public event Action<int>? ChangePomodoroCounter;

        void IModelController.Pause()
        {
            timer.Stop();
            ChangeTimerState?.Invoke(timer.Enabled);
        }

        void IModelController.Reset()
        {
            //остановка таймера
            timer.Stop();
            ChangeTimerState?.Invoke(timer.Enabled);

            //инициализация очереди
            InitQueue();
            ChangePomodoroCounter?.Invoke(currentStep.Number);
            ChangeTime?.Invoke(currentStep);
        }

        void IModelController.Skip()
        {
            //Остановка таймера
            timer.Stop();
            ChangeTimerState?.Invoke(timer.Enabled);

            //Установка следующего шага
            if (steps.Count == 0)
                InitQueue();

            currentStep = steps.Dequeue();
            ChangePomodoroCounter?.Invoke(currentStep.Number);
            ChangeTime?.Invoke(currentStep);
        }

        void IModelController.Start()
        {
            timer.Start();
            ChangeTimerState?.Invoke(timer.Enabled);
        }
    }
}
