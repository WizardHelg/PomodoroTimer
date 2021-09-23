using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class ModelStateView
    {
        private readonly Model.Model model;

        public ModelStateView(Model.Model model)
        {
            this.model = model;
        }
    }
}
