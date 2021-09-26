namespace PomodoroTimer.Model
{
    internal interface IModelController
    {
        void Start();
        void Pause();
        void Skip();
        void Reset();
    }
}
