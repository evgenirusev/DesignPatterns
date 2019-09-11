using Implementation.AbstractProducts;
using System;

namespace Implementation.ConcreteProducts
{
    public class SazkaFootballBet : IFootballBet
    {
        public void DisplayFootballBet()
        {
            Console.WriteLine("Display -> Sazka Football Bet");
        }
    }
}
