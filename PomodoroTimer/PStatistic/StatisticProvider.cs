using PomodoroTimer.PTimer.Model;
using System;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTimer.PStatistic
{
    internal class StatisticProvider
    {
        DateTime currentDate;
        int today, yesterday, currentWeek, previousWeek;
        Label? label;

        public StatisticProvider(IStatisticModel statisticModel, Statistic statistic)
        {
            statisticModel.PomodoroComplited += StatisticModel_PomodoroComplited;
            
            (currentDate, today, yesterday, currentWeek, previousWeek) = statistic;

            Update(withAdd: false);
        }

        public static StatisticProvider Build(IStatisticModel statisticModel, Statistic statistic) => 
            new(statisticModel, statistic);

        public Statistic GetStatistic() => new()
        {
            CurrentDate = currentDate,
            Today = today,
            Yesterday = yesterday,
            CurrentWeek = currentWeek,
            PreviousWeek = previousWeek
        };

        public StatisticProvider AddView(Label label)
        {
            this.label = label;
            UpdateView();

            return this;
        }

        private void StatisticModel_PomodoroComplited() => Update(withAdd: true);

        private void Update(bool withAdd)
        {
            if (UpdateDate())
                ShiftStatistic();

            if (withAdd)
            {
                today++;
                currentWeek++;
            }

            UpdateView();    
        }

        private bool UpdateDate()
        {
            DateTime now = DateTime.Now.Date;

            if(currentDate < now)
            {
                currentDate = now;
                return true;
            }

            return false;
        }

        private void ShiftStatistic()
        {
            if (currentDate.DayOfWeek == DayOfWeek.Monday)
            {
                previousWeek = currentWeek;
                currentWeek = 0;
            }

            yesterday = today;
            today = 0;
        }

        private void UpdateView()
        {
            if (label == null)
                return;

            StringBuilder builder = new();

            builder.AppendLine($"Статистика по отработанным помидоркам:");
            builder.AppendLine($"За сегодня - {today}");
            builder.AppendLine($"Вчера - {yesterday}");
            builder.AppendLine($"На этой недели - {currentWeek}");
            builder.AppendLine($"За прошлую неделю - {previousWeek}");

            label.Text = builder.ToString();
        }
    }
}
