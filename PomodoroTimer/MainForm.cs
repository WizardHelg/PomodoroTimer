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
        private readonly SettingsProvider provider;
        //private readonly Binder binder; //В статику его
        private Model.Model model;
        public MainForm()
        {
            InitializeComponent();

            Settings settings = JsonFileBroker.Load<Settings>(SettingsFilePath);

            provider = new SettingsProvider(settings)
                           .AddControl(Settings.Name.WorkPeriod, numericUpDownWork)
                           .AddControl(Settings.Name.SmallRelaxPeriod, numericUpDownSmallRelax)
                           .AddControl(Settings.Name.BigRelaxPeriod, numericUpDownBigRelax)
                           .AddControl(Settings.Name.PomodoroAmaunt, numericUpDownAmount);

            model = new Model.Model(provider);

            ControlBinder.Build(model)
                .AddBinding(ControlBinder.Name.Start, buttonStart)
                .AddBinding(ControlBinder.Name.Pause, buttonPause)
                .AddBinding(ControlBinder.Name.Skip, buttonSkip)
                .AddBinding(ControlBinder.Name.Reset, buttonReset);

            ViewBinder.Build(model)
                .AddBinding(ViewBinder.Name.Timer, labelTimer);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonFileBroker.Save(provider.GetSetting(), SettingsFilePath);
        }
    }
}
