using Implementation.AbstractProducts;
using System;

namespace Implementation.ConcreteProducts
{
    public class ToteBasketballBet : IBasketballBet
    {
        public void DisplayBasketballBet()
        {
            Console.WriteLine("Display -> Tote Basketball Bet");
        }
    }
}
