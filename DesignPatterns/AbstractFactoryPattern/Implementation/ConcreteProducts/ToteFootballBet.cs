using Implementation.AbstractProducts;
using System;

namespace Implementation.ConcreteProducts
{
    public class ToteFootballBet : IFootballBet
    {
        public void DisplayFootballBet()
        {
            Console.WriteLine("Display -> Tote Football Bet");
        }
    }
}
