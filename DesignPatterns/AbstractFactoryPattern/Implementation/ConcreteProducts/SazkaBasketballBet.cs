using Implementation.AbstractProducts;
using System;

namespace Implementation.ConcreteProducts
{
    public class SazkaBasketballBet : IBasketballBet
    {
        public void DisplayBasketballBet()
        {
            Console.WriteLine("Display -> Sazka Basketball Bet");
        }
    }
}
