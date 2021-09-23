using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class Binder
    {
        private readonly Model.IModelController model;

        public enum Name
        {
            Start,
            Pause,
            Skip,
            Reset
        }

        public static Binder Build(Model.IModelController model) => new Binder(model);

        private Binder(Model.IModelController model)
        {
            this.model = model;
        }

        public Binder AddBinding(Name name, Control control)
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
