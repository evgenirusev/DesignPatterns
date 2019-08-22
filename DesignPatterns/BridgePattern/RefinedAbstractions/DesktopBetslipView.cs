using BridgePattern.Abstractions;
using BridgePattern.Implementors;
using System;

namespace BridgePattern.RefinedAbstractions
{
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
}
