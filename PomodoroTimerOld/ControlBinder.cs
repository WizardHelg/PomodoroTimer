using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class ControlBinder
    {
        private readonly Model.IModelController model;

        public enum Name
        {
            Start,
            Pause,
            Skip,
            Reset
        }

        public static ControlBinder Build(Model.IModelController model) => new ControlBinder(model);

        private ControlBinder(Model.IModelController model)
        {
            this.model = model;
        }

        public ControlBinder AddBinding(Name name, Control control)
        {
            Action action = name switch
            {
                Name.Start => () => model.Start(),
                Name.Pause => () => model.Pause(),
                Name.Skip => () => model.Skip(),
                Name.Reset => () => model.Reset(),
                _ => () => { }
            };

            control.Click += (sender, e) => action();

            return this;
        }
    }
}
