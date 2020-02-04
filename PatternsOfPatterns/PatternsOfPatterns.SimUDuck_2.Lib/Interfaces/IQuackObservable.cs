namespace PatternsOfPatterns.SimUDuck_2.Lib.Interfaces
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}