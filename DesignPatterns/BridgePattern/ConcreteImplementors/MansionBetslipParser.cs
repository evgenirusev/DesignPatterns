﻿using BridgePattern.Implementors;

namespace BridgePattern.ConcreteImplementors
{
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
