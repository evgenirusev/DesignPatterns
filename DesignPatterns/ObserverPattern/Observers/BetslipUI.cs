using System;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    public class BetslipUI : IObserver
    {
        private SportsDataSubject _dataSource;

        public BetslipUI(SportsDataSubject subject)
        {
            _dataSource = subject;
            subject.Register(this);
        }

        public void Update()
        {
            Console.WriteLine("Rendering Betslip UI with new Sports Data -> " + _dataSource.SportsData);
        }
    }
}
