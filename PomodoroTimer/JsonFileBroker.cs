using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace PomodoroTimer
{
    /// <summary>
    /// Посредник между json файлами и объектами
    /// </summary>
    internal class JsonFileBroker
    {
        /// <summary>
        /// Десериализовать объект из файла
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Десериализованный объект</returns>
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

        /// <summary>
        /// Сериализовать объект в файл
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="obj">Объект для сериализации</param>
        /// <param name="filePath">Путь к файлу</param>
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
