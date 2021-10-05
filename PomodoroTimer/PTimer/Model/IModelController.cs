namespace PomodoroTimer.PTimer.Model
{
    internal interface IModelController
    {
        void Start();
        void Pause();
        void Skip();
        void Reset();
        void Exit();
    }
}
