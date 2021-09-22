using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace PomodoroTimer
{
    internal record SettingDTO(int WorkPeriod, int SmallRelaxPeriod, int BigRelaxPeriod, int PomodoroAmaunt);
    internal class JsonFileBroker
    {
        public static T Load<T>(string filePath) where T : new()
        {
            try
            {
                using var fs = new FileStream(filePath, FileMode.OpenOrCreate);
                return JsonSerializer.Deserialize<T>(fs) ?? new T();
            }
            catch
            {
                return new T();
            }
        }

        public static void Save<T>(T obj, string filePath) where T : new()
        {
            using var fs = new FileStream(filePath,  FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fs, obj, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }
    }
}
