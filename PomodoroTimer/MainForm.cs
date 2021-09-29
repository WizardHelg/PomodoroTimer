using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class MainForm : Form
    {
        private const string SettingsFilePath = "appsetting.json";
        private readonly SettingsProvider provider;
        private readonly Model.Model model;

        private FormWindowState windowState = FormWindowState.Normal;

        public MainForm()
        {
            InitializeComponent();

            Settings settings = JsonFileBroker.Load<Settings>(SettingsFilePath);

            provider = SettingsProvider.Build(settings)
                           .AddControl(Settings.Name.WorkPeriod, numericUpDownWork)
                           .AddControl(Settings.Name.SmallRelaxPeriod, numericUpDownSmallRelax)
                           .AddControl(Settings.Name.BigRelaxPeriod, numericUpDownBigRelax)
                           .AddControl(Settings.Name.PomodoroAmaunt, numericUpDownAmount);

            model = new Model.Model(provider);

            ControlBinder.Build(model)
                .AddBinding(ControlBinder.Name.Start, buttonStart)
                .AddBinding(ControlBinder.Name.Start, tsmiStart)
                .AddBinding(ControlBinder.Name.Pause, buttonPause)
                .AddBinding(ControlBinder.Name.Pause, tsmiPause)
                .AddBinding(ControlBinder.Name.Skip, buttonSkip)
                .AddBinding(ControlBinder.Name.Skip, tsmiSkip)
                .AddBinding(ControlBinder.Name.Reset, buttonReset)
                .AddBinding(ControlBinder.Name.Reset, tsmiReset)
                .AddBinding(ControlBinder.Name.Exit, buttonExit)
                .AddBinding(ControlBinder.Name.Exit, tsmiExit);

            ViewBinder.Build(model)
                .AddBinding(ViewBinder.Name.Timer, labelTimer)
                .AddBinding(ViewBinder.Name.Number, labelPomodoroNumber);

            model.Run();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonFileBroker.Save(provider.GetSetting(), SettingsFilePath);
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
