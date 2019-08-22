using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            BetslipView toteMobileBetslipView = new MobileBetslipView(new ToteBetslipParser());
            BetslipView mansionDesktopBetslipView = new DesktopBetslipView(new MansionBetslipParser());

            toteMobileBetslipView.DisplayBetslip();
            Console.WriteLine();
            mansionDesktopBetslipView.DisplayBetslip();
        }
    }

    public abstract class BetslipView
    {
        protected IBetslipParser _betslipParser;

        public BetslipView(IBetslipParser betslipParser)
        {
            _betslipParser = betslipParser;
        }

        public abstract void DisplayBetslip();
    }

    public class MobileBetslipView : BetslipView
    {
        public MobileBetslipView(IBetslipParser betslipParser) : base(betslipParser)
        { }

        public override void DisplayBetslip()
        {
            Console.WriteLine("Displaying Betslip for Mobile...");
            Console.WriteLine("(For Mobile) Bet Type - {0}", _betslipParser.GetBetsType());
            Console.WriteLine("(For Mobile) Number of Bets - {0}", _betslipParser.GetNumberOfBets());
        }
    }

    public class DesktopBetslipView : BetslipView
    {
        public DesktopBetslipView(IBetslipParser betslipParser) : base(betslipParser)
        { }

        public override void DisplayBetslip()
        {
            Console.WriteLine("Displaying Betslip for Desktop...");
            Console.WriteLine("(For Desktop) Bet Type - {0}", _betslipParser.GetBetsType());
            Console.WriteLine("(For Desktop) Number of Bets - {0}", _betslipParser.GetNumberOfBets());
        }
    }

    public interface IBetslipParser
    {
        int GetNumberOfBets();
        string GetBetsType();
    }

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

    public class MansionBetslipParser : IBetslipParser
    {
        public string GetBetsType()
        {
            return "Mansion";
        }

        public int GetNumberOfBets()
        {
            return 5;
        }
    }
}
