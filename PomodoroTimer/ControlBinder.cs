using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class ControlBinder
    {
        public enum Name
        {
            Start,
            Pause,
            Skip,
            Reset,
            Exit
        }

        private readonly Model.IModelController model;

        public static ControlBinder Build(Model.IModelController model) => new(model);

        private ControlBinder(Model.IModelController model) => this.model = model;

        public ControlBinder AddBinding(Name name, Control control)
        {
            control.Click += CreateHandler(name);
            return this;
        }

        public ControlBinder AddBinding(Name name, ToolStripMenuItem control)
        {
            control.Click += CreateHandler(name);
            return this;
        }

        private EventHandler CreateHandler(Name name)
        {
            Action action = GetAction(name);
            return (sender, e) => action();
        }

        private Action GetAction(Name name) => name switch
        {
            Name.Start => () => model.Start(),
            Name.Pause => () => model.Pause(),
            Name.Skip => () => model.Skip(),
            Name.Reset => () => model.Reset(),
            Name.Exit => () => model.Exit(),
            _ => () => { }
        };
    }
}
