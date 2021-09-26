using System.Collections.Generic;
using System.Windows.Forms;

namespace PomodoroTimer
{
    /// <summary>
    /// Связь настроек и контролов настроек
    /// </summary>
    internal class SettingsProvider
    {
        private readonly Settings settings;
        private readonly Dictionary<Settings.Name, NumericUpDown> controls = new();

        public static SettingsProvider Build(Settings settings) => new(settings);

        private SettingsProvider(Settings settings) => this.settings = settings;

        /// <summary>
        /// Добавить контрол настроек
        /// </summary>
        /// <param name="name">Имя настройки</param>
        /// <param name="control">Контрол настройки</param>
        public SettingsProvider AddControl(Settings.Name name, NumericUpDown control)
        {
            if (controls.ContainsKey(name))
                controls[name] = control;
            else
                controls.Add(name, control);

            control.Value = settings[name];

            return this;
        }

        /// <summary>
        /// Считывает данные с контролов настроек и генерирует файл настроек
        /// </summary>
        /// <returns>Файл настроек</returns>
        public Settings GetSetting()
        {
            var returnValue = new Settings();

            foreach(var item in controls)
                returnValue[item.Key] = (int)item.Value.Value;

            return returnValue;
        }

        public int this[Settings.Name name]
        {
            get
            {
                if (controls.ContainsKey(name))
                    return (int)controls[name].Value;
                else
                    return settings[name];
            }
        }
    }
}
