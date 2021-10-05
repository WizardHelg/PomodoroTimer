using System;
using System.Threading;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal static class Program
    {
        public static bool IsSingle()
        {
            Mutex _ = new(true, "PomodoroMutex", out bool result);
            return result;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsSingle())
            {
                MessageBox.Show("Другой экземпляр приложения уже запущен", "Pomodoro Timer");
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
