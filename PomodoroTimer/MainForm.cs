using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class MainForm : Form
    {
        private const string SettingsFilePath = "appsetting.json";
        private readonly SettingsProvider provider;
        private readonly Model.Model model;

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
                .AddBinding(ControlBinder.Name.Pause, buttonPause)
                .AddBinding(ControlBinder.Name.Skip, buttonSkip)
                .AddBinding(ControlBinder.Name.Reset, buttonReset);

            ViewBinder.Build(model)
                .AddBinding(ViewBinder.Name.Timer, labelTimer);

            model.Run();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonFileBroker.Save(provider.GetSetting(), SettingsFilePath);
        }
    }
}
