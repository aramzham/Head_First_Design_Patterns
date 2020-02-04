namespace PatternsOfPatterns.SimUDuck_2.Lib.Interfaces
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}