using StrategyPattern.Implementation.Strategies;

namespace StrategyPattern.Implementation.ConcreteStrategy
{
    public class CenterPropsBuilder : IPropsBuilderStrategy
    {
        public string BuildProps()
        {
            // implementation details
            return "CenterProps - blockModifier: 100, isSelected: false, hasDictionary: true";
        }
    }
}
