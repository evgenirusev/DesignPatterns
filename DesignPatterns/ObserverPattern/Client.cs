using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            SportsDataSubject subject = new SportsDataSubject();

            EventListUI eventListUI = new EventListUI(subject);
            BetslipUI betslipUI = new BetslipUI(subject);

            subject.SportsData = "{EventID: 5, IsFavourite: false}";
        }
    }
}
