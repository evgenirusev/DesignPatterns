using BridgePattern.Abstractions;
using BridgePattern.ConcreteImplementors;
using BridgePattern.RefinedAbstractions;
using ConcreteImplementors;
using System;

namespace BridgePattern
{
    class Client
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
}
