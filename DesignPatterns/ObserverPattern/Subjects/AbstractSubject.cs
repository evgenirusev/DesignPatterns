using ObserverPattern.Observers;
using System.Collections.Generic;

namespace ObserverPattern.Subjects
{
    public abstract class AbstractSubject
    {
        private List<IObserver> _observers;

        public AbstractSubject()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
                observer.Update();
        }
    }
}
