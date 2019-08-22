using Implementation.Abstractions;
using Implementation.ConcreteImplementors;
using Implementation.RefinedAbstractions;
using ConcreteImplementors;
using System;

namespace Implementation
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
