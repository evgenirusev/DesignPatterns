using StrategyPattern.Implementation.Strategies;

namespace StrategyPattern.Implementation.ConcreteStrategy
{
    public class SidePropsBuilder : IPropsBuilderStrategy
    {
        public string BuildProps()
        {
            // implementation details
            return "SideProps - blockModifier: 200, isSelected: true, hasDictionary: false";
        }
    }
}
