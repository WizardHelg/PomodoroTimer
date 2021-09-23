using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace PomodoroTimer
{
    public partial class MainForm : Form
    {
        private const string SettingsFilePath = "appsetting.json";
        private SettingsProvider provider;
        public MainForm()
        {
            InitializeComponent();

            Settings settings = JsonFileBroker.Load<Settings>(SettingsFilePath);

            provider = new SettingsProvider(settings)
                           .AddControl(Settings.Name.WorkPeriod, numericUpDownWork)
                           .AddControl(Settings.Name.SmallRelaxPeriod, numericUpDownSmallRelax)
                           .AddControl(Settings.Name.BigRelaxPeriod, numericUpDownBigRelax)
                           .AddControl(Settings.Name.PomodoroAmaunt, numericUpDownAmount);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonFileBroker.Save(provider.GetSetting(), SettingsFilePath);
        }
    }
}
