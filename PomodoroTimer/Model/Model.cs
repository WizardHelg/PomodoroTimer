using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal partial class Model : IModelController, IModelView
    {
        class Step
        {
            private bool isNew = true;
            public int Number { get; init; }
            public int Seconds { get; set; }

            public static implicit operator TimeSpan(Step step) => TimeSpan.FromSeconds(step.Seconds);
        }

        private readonly SettingsProvider settingsProvider;
        private readonly Queue<Step> steps = new();
        private readonly Timer timer;

        private Step currentStep;
        
        public Model(SettingsProvider settingsProvider)
        {
            timer = new Timer()
            {
                Interval = 1000,
                Enabled = false,
            };
            timer.Tick += Timer_Tick;

            this.settingsProvider = settingsProvider;

            InitQueue();
            currentStep = steps.Dequeue();
        }

        public void Run()
        {
            ChangeTime?.Invoke(currentStep);
            ChangeTimerState?.Invoke(timer.Enabled);
            ChangePomodoroCounter?.Invoke(currentStep.Number);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if(currentStep.Seconds > 1)
            {
                currentStep.Seconds--;
            }
            else
            {
                timer.Stop();
                ChangeTimerState?.Invoke(timer.Enabled);

                if (steps.Count == 0)
                    InitQueue();

                currentStep = steps.Dequeue();
                ChangePomodoroCounter?.Invoke(currentStep.Number);
            }

            ChangeTime?.Invoke(currentStep);
        }

        private void InitQueue()
        {
            bool isWork = true;

            int amaunt = settingsProvider[Settings.Name.PomodoroAmaunt];
            int work = settingsProvider[Settings.Name.WorkPeriod] * 60;
            int smallRelax = settingsProvider[Settings.Name.SmallRelaxPeriod] * 60;
            int bigRelax = settingsProvider[Settings.Name.BigRelaxPeriod] * 60;

            steps.Clear();

            for (int i = 0; i < amaunt; i++)
            {
                bool isBigRelax = amaunt - i == 2;

                steps.Enqueue(new Step()
                {
                    Number = i + 1,
                    Seconds = isWork ? work
                                     : isBigRelax ? bigRelax : smallRelax
                });

                isWork = !isWork;
            }
        }
        
    }
}
