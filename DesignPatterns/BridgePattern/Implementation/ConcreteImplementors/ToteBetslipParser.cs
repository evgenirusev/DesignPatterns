using Implementation.Implementors;

namespace ConcreteImplementors
{
    public class ToteBetslipParser : IBetslipParser
    {
        public string GetBetsType()
        {
            return "Tote";
        }

        public int GetNumberOfBets()
        {
            return 2;
        }
    }
}
