using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class ViewBinder
    {
        public enum Name
        {
            Timer,
            Number
        }

        private readonly Dictionary<Name, Control> controls = new();

        public static ViewBinder Build(Model.IModelView model) => new(model);

        private ViewBinder(Model.IModelView model)
        {
            model.ChangeTime += Model_ChangeTime;
            model.ChangePomodoroNumber += Model_ChangePomodoroNumber;
        }

        private void Model_ChangePomodoroNumber(int number)
        {
            if (controls.TryGetValue(Name.Number, out var control))
                control.Text = $"Номер помидорки: {number}";
        }

        private void Model_ChangeTime(TimeSpan time)
        {
            if (controls.TryGetValue(Name.Timer, out var control))
                control.Text = @$"{time:mm\:ss}";
        }

        public ViewBinder AddBinding(Name name, Control control)
        {
            if(controls.ContainsKey(name))
                controls[name] = control;
            else
                controls.Add(name, control);

            return this;
        }
    }
}
