using System.IO;
using System.Text;
using System.Text.Json;

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
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string json = Encoding.UTF8.GetString(buffer);
                return JsonSerializer.Deserialize<T>(json) ?? new T();
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
            
            string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions()
            {
                WriteIndented = true
            });

            byte[] buffer = Encoding.UTF8.GetBytes(json);
            fs.Write(buffer, 0, buffer.Length);
            
        }
    }
}
