using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PomodoroTimer
{
    internal class ViewBinder
    {
        private readonly Dictionary<Name, Control> controls = new();

        public enum Name
        {
            Timer,
            TimerState,
            Counter
        }

        public static ViewBinder Build(Model.IModelView model) => new ViewBinder(model);

        private ViewBinder(Model.IModelView model)
        {
            model.ChangeTime += Model_ChangeTime;
            model.ChangeTimerState += Model_ChangeTimerState;
            model.ChangePomodoroCounter += Model_ChangeCounter;
        }

        public ViewBinder AddBinding(Name name, Control control)
        {
            if(controls.ContainsKey(name))
                controls[name] = control;
            else
                controls.Add(name, control);

            return this;
        }

        private void Model_ChangeTime(TimeSpan time)
        {
            if (controls.TryGetValue(Name.Timer, out var control))
                control.Text = @$"{time:mm\:ss}";
        }

        private void Model_ChangeTimerState(bool state)
        {
            if (controls.TryGetValue(Name.TimerState, out var control))
                control.Text = state ? string.Empty : "Пауза";
        }

        private void Model_ChangeCounter(int counter)
        {
            if(controls.TryGetValue(Name.Counter, out var control))
                control.Text = counter.ToString();
        }
    }
}
