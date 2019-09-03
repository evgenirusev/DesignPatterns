using System;

namespace CommandPattern.Implementation.Receivers
{
    public class BetPlacementUtil : IBetPlacer
    {
        public void PlaceBet()
        {
            Console.WriteLine("Placing Bets...");
        }
    }
}
