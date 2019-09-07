using StrategyPattern.Implementation.ConcreteStrategy;
using StrategyPattern.Implementation.Context;
using StrategyPattern.Implementation.Strategies;

namespace StrategyPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            IPropsBuilderStrategy centerPropsBuilder = new CenterPropsBuilder();
            IPropsBuilderStrategy sidePropsBuilder = new SidePropsBuilder();

            State state = new State(centerPropsBuilder);
            System.Console.WriteLine(state.BuildProps());

            state = new State(sidePropsBuilder);
            System.Console.WriteLine(state.BuildProps()); 

            System.Console.ReadLine();
        }
    }
}
