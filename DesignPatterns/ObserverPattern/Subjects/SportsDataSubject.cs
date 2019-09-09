namespace ObserverPattern.Subjects
{
    public class SportsDataSubject : AbstractSubject
    {
        private string _sportsData;

        public string SportsData {
            get { return _sportsData; }
            set
            {
                _sportsData = value;
                base.Notify();
            }
        }
    }
}
