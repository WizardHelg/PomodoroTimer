using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.Model
{
    internal class Model : IModelController, IModelView
    {
        SettingsProvider settingsProvider;

        public Model(SettingsProvider settingsProvider)
        {
            this.settingsProvider = settingsProvider;
        }

        //interface implementation remove to partial class
        bool IModelView.TimerEnable => throw new NotImplementedException();

        DateTime IModelView.Time => throw new NotImplementedException();

        int IModelView.PomodoroCounter => throw new NotImplementedException();

        void IModelController.Pause()
        {
            throw new NotImplementedException();
        }

        void IModelController.Reset()
        {
            throw new NotImplementedException();
        }

        void IModelController.Skip()
        {
            throw new NotImplementedException();
        }

        void IModelController.Start()
        {
            throw new NotImplementedException();
        }
    }
}
