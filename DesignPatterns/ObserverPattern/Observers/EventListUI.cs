using System;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public class EventListUI : IObserver
    {
        private SportsDataSubject _dataSource;

        public EventListUI(SportsDataSubject subject)
        {
            _dataSource = subject;
            subject.Register(this);
        }

        public void Update()
        {
            Console.WriteLine("Rendering EventList UI with new Sports Data -> " + _dataSource.SportsData);
        }
    }
}
