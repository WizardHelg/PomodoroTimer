using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.PSettings
{
    internal interface IObserver
    {
        void Update(Settings settings);
    }
}
