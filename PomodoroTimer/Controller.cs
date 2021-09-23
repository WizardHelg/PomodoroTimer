using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class Controller
    {
        private readonly Dictionary<Name, Action> controls = new();
        private readonly Model.IModelTimerState model;

        public enum Name
        {
            Start,
            Pause,
            Skip,
            Reset
        }

        public event Action? Start, Pause, Skip, Reset;

        public Controller(Model.IModelTimerState model)
        {
            this.model = model;
        }

        public Controller AddControl(Name name, Control control)
        {
            Action action = name switch
            {
                Name.Start => () => model.TimerEnable = true,
                Name.Pause => () => model.TimerEnable = false,
                Name.Skip => () => model.Skip(),
                Name.Reset => () => model.Reset(),
                _ => () => { }
            };

            if (controls.ContainsKey(name))
                controls[name] = action;
            else
                controls.Add(name, action);

            return this;
        }
    }
}
