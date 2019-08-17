using AbstractFactory.AbstractFactories;
using System;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            IBetsAbstractFactory toteBetsAbstractFactory = new ToteBetsAbstractFactory();
            IBetsAbstractFactory mansionBetsAbstractFactory = new MansionBetsAbstractFactory();

            BetsState toteBetsState = new BetsState(toteBetsAbstractFactory);
            toteBetsState.BetPropsBuilder();

            Console.WriteLine();

            BetsState mansionBetsState = new BetsState(mansionBetsAbstractFactory);
            mansionBetsState.BetPropsBuilder();

            Console.ReadLine();
        }
    }
}
