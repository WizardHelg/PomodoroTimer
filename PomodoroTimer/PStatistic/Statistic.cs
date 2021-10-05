using System;
using System.Text.Json.Serialization;

namespace PomodoroTimer.PStatistic
{
    internal record Statistic
    {
        [JsonPropertyName("currentDate")]
        public DateTime CurrentDate { get; init; }

        [JsonPropertyName("today")]
        public int Today { get; init; }

        [JsonPropertyName("yesterday")]
        public int Yesterday { get; init; }

        [JsonPropertyName("currentWeek")]
        public int CurrentWeek { get; init; }

        [JsonPropertyName("previousWeek")]
        public int PreviousWeek { get; init; }

        public void Deconstruct(out DateTime currentDate,
                                out int today,
                                out int yesterday,
                                out int currentWeek,
                                out int previousWeek) =>
            (currentDate, today, yesterday, currentWeek, previousWeek) = 
            (CurrentDate, Today, Yesterday, CurrentWeek, PreviousWeek);
    }
}
