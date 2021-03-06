using PomodoroTimer.PPlaner;
using PomodoroTimer.PSettings;
using PomodoroTimer.PStatistic;
using PomodoroTimer.PTimer;
using PomodoroTimer.PTimer.Model;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class MainForm : Form
    {
        private const string SettingsFilePath = "appsetting.json";
        private const string StatisticFilePath = "statistic.json";
        private readonly SettingsProvider settingsProvider;
        private readonly StatisticProvider statisticProvider;
        private readonly Model model;

        private FormWindowState windowState = FormWindowState.Normal;

        public MainForm()
        {
            InitializeComponent();

            Application.ApplicationExit += Application_ApplicationExit;

            Settings settings = JsonFileBroker.Load<Settings>(SettingsFilePath);

            settingsProvider = SettingsProvider.Build(settings)
                           .AddObserver(new Planer(labelPlaning))
                           .AddControl(Settings.Name.WorkPeriod, numericUpDownWork)
                           .AddControl(Settings.Name.SmallRelaxPeriod, numericUpDownSmallRelax)
                           .AddControl(Settings.Name.BigRelaxPeriod, numericUpDownBigRelax)
                           .AddControl(Settings.Name.PomodoroAmaunt, numericUpDownAmount)
                           .AddControl(Settings.Name.Cycles, numericUpDownCycles);                          

            model = new Model(settingsProvider);

            Controler.Build(model)
                .AddBinding(Controler.Name.Start, buttonStart)
                .AddBinding(Controler.Name.Start, tsmiStart)
                .AddBinding(Controler.Name.Pause, buttonPause)
                .AddBinding(Controler.Name.Pause, tsmiPause)
                .AddBinding(Controler.Name.Skip, buttonSkip)
                .AddBinding(Controler.Name.Skip, tsmiSkip)
                .AddBinding(Controler.Name.Reset, buttonReset)
                .AddBinding(Controler.Name.Reset, tsmiReset)
                .AddBinding(Controler.Name.Exit, buttonExit)
                .AddBinding(Controler.Name.Exit, tsmiExit);

            Viewer.Build(model)
                .AddBinding(Viewer.Name.Timer, labelTimer)
                .AddBinding(Viewer.Name.Number, labelPomodoroNumber);

            Statistic statistic = JsonFileBroker.Load<Statistic>(StatisticFilePath);

            statisticProvider = StatisticProvider.Build(model, statistic)
                                .AddView(labelStatistic);

            model.Run();
        }

        private void Application_ApplicationExit(object? sender, System.EventArgs e)
        {
            JsonFileBroker.Save(settingsProvider.GetSetting(), SettingsFilePath);
            JsonFileBroker.Save(statisticProvider.GetStatistic(), StatisticFilePath);
            statisticProvider.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = windowState;
            ShowInTaskbar = true;
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
                ShowInTaskbar = false;
            else
                windowState = WindowState;
        }
    }
}
