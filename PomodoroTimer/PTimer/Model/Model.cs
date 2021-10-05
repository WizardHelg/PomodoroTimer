using PomodoroTimer.PSettings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PomodoroTimer.PTimer.Model
{
    internal partial class Model : IModelController, IModelView, IStatisticModel
    {
        class Step
        {
            public enum StepType
            {
                Work,
                Relax
            }

            public StepType Type { get; init; }

            public int Seconds { get; set; }

            public static implicit operator TimeSpan(Step step) => TimeSpan.FromSeconds(step.Seconds);
        }

        private readonly SettingsProvider settingsProvider;
        private readonly Queue<Step> steps = new();
        private readonly Timer timer;

        private Step currentStep;
        private int currentStepNumber = 0;
        private int maxStepNumber = 1;
        
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
            currentStepNumber++;
        }

        public void Run()
        {
            ChangeTime?.Invoke(currentStep);
            ChangePomodoroNumber?.Invoke(currentStepNumber, maxStepNumber);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if(currentStep.Seconds > 1)
            {
                currentStep.Seconds--;
            }
            else
            {
                bool startNext = false;
                timer.Stop();

                switch (currentStep.Type)
                {
                    case Step.StepType.Relax:
                        if(MessageBox.Show(
                            "Отдых окончен, пора поработать!\nЗапустить работу?",
                            "PomodoroTimer",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                        {
                            startNext = true;
                        }
                        break;

                    case Step.StepType.Work:
                        if(MessageBox.Show(
                            "Хватит работать, пора отдыхать!\nЗапустить отдых?",
                            "PomodoroTimer",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                        {
                            startNext = true;
                        }
                        break;
                }

                if (steps.Count == 0)
                    InitQueue();

                currentStep = steps.Dequeue();
                currentStepNumber++;
                PomodoroComplited?.Invoke();

                if (startNext)
                {
                    timer.Start();
                }
            }

            ChangeTime?.Invoke(currentStep);
            ChangePomodoroNumber?.Invoke(currentStepNumber, maxStepNumber);
        }

        private void InitQueue()
        {
            bool isWork = true;


            Settings settings = settingsProvider.GetSetting();
            int amaunt = settings.PomodoroAmaunt * 2;
            int work = settings.WorkPeriod * 60;
            int smallRelax = settings.SmallRelaxPeriod * 60;
            int bigRelax = settings.BigRelaxPeriod * 60;

            maxStepNumber = settings.PomodoroAmaunt * settings.Cycles;
            currentStepNumber = 0;

            steps.Clear();

            for (int i = 0; i < amaunt; i++)
            {
                bool isBigRelax = i == amaunt - 1;

                steps.Enqueue(new Step()
                {
                    Type = isWork ? Step.StepType.Work : Step.StepType.Relax,
                    Seconds = isWork ? work
                                     : isBigRelax ? bigRelax : smallRelax
                });

                isWork = !isWork;
            }       
        }
    }
}
