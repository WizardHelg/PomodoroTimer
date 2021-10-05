using PomodoroTimer.PSettings;
using System;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTimer.PPlaner
{
    internal class Planer : IObserver
    {
        private readonly Label view;

        public Planer(Label view) => this.view = view;

        public void Update(Settings settings)
        {
            int allPomodoro = settings.PomodoroAmaunt * settings.Cycles;
            TimeSpan allWorkTime = TimeSpan.FromMinutes(allPomodoro * settings.WorkPeriod);
            int allSmallRelaxMinutes = (allPomodoro - settings.Cycles) * settings.SmallRelaxPeriod;
            int allBigRelaxMinutes = settings.Cycles * settings.BigRelaxPeriod;
            TimeSpan allRelaxTime = TimeSpan.FromMinutes(allSmallRelaxMinutes + allBigRelaxMinutes);
            TimeSpan allTime = allWorkTime + allRelaxTime;

            StringBuilder builder = new();

            builder.AppendLine($"Всего помидорок: - {allPomodoro}");
            builder.AppendLine($"Всего работы: - {TimeSpanToString(allWorkTime)}");
            builder.AppendLine($"Всего отдыха: - {TimeSpanToString(allRelaxTime)}");
            builder.AppendLine($"Всего времени: - {TimeSpanToString(allTime)}");

            view.Text = builder.ToString();
        }

        private static string TimeSpanToString(TimeSpan timeSpan)
        {
            return $"{(int)timeSpan.TotalHours}:{timeSpan.Minutes}:{timeSpan.Seconds}";
        }
    }
}
