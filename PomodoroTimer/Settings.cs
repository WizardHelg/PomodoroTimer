using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace PomodoroTimer
{
    internal class Settings
    {
        private const string SettingsFileName = "appsetting.json";

        [JsonPropertyName("workPeriod")]
        public int WorkPeriod { get; set; } = 25;

        [JsonPropertyName("smallRelaxPeriod")]
        public int SmallRelaxPeriod { get; set; } = 5;

        [JsonPropertyName("bigRelaxPeriod")]
        public int BigRelaxPeriod { get; set; } = 15;

        [JsonPropertyName("pomodoroAmount")]
        public int PomodoroAmaunt { get; set; } = 4;

        public static Settings Load()
        {
            using var fs = new FileStream(SettingsFileName, FileMode.OpenOrCreate);
            return JsonSerializer.Deserialize<Settings>(fs) ?? new Settings(); 
        }

        public static void Save(Settings settings)
        {
            using var fs = new FileStream(SettingsFileName,  FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fs, settings, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
    }
}
