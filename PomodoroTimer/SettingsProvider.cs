using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    /// <summary>
    /// Связь настроек и контролов настроек
    /// </summary>
    internal class SettingsProvider
    {
        private Settings settings;

        private Dictionary<Settings.Name, NumericUpDown> controls = new();

        public SettingsProvider(Settings settings)
        {
            this.settings = settings;
        }
        
        /// <summary>
        /// Добавить контрол настроек
        /// </summary>
        /// <param name="name">Имя настройки</param>
        /// <param name="control">Контрол настройки</param>
        public void AddControl(Settings.Name name, NumericUpDown control)
        {
            if (controls.ContainsKey(name))
                controls[name] = control;
            else
                controls.Add(name, control);

            control.Value = settings[name];
        }

        /// <summary>
        /// Считывает данные с контролов настроек и генерирует файл настроек
        /// </summary>
        /// <returns>Файл настроек</returns>
        public Settings GetSetting()
        {
            Settings settings1 = new Settings();

            foreach(var item in controls)
            {
                settings[item.Key] = (int)item.Value.Value;
            }

            return settings1;
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
