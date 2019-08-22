using BridgePattern.Abstractions;
using BridgePattern.Implementors;
using System;

namespace BridgePattern.RefinedAbstractions
{
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
}
