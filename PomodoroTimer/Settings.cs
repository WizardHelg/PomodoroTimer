using System.Text.Json.Serialization;

namespace PomodoroTimer
{
    internal class Settings
    {
        [JsonPropertyName("workPeriod")]
        public int WorkPeriod { get; set; } = 25;

        [JsonPropertyName("smallRelaxPeriod")]
        public int SmallRelaxPeriod { get; set; } = 5;

        [JsonPropertyName("bigRelaxPeriod")]
        public int BigRelaxPeriod { get; set; } = 15;

        [JsonPropertyName("pomodoroAmount")]
        public int PomodoroAmaunt { get; set; } = 4;
    }
}
