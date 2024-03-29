﻿using Implementation.Implementors;

namespace Implementation.Abstractions
{
    public abstract class BetslipView
    {
        protected IBetslipParser _betslipParser;

        public BetslipView(IBetslipParser betslipParser)
        {
            _betslipParser = betslipParser;
        }

        public abstract void DisplayBetslip();
    }
}
