using Implementation.AbstractFactories;
using System;

namespace Implementation
{
    class Client
    {
        static void Main(string[] args)
        {
            IBetsAbstractFactory toteBetsAbstractFactory = new ToteBetsAbstractFactory();
            IBetsAbstractFactory sazkaBetsAbstractFactory = new SazkaBetsAbstractFactory();

            BetsState toteBetsState = new BetsState(toteBetsAbstractFactory);
            toteBetsState.BetPropsBuilder();

            Console.WriteLine();

            BetsState mansionBetsState = new BetsState(sazkaBetsAbstractFactory);
            mansionBetsState.BetPropsBuilder();

            Console.ReadLine();
        }
    }
}
