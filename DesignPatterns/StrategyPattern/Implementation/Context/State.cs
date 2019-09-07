using StrategyPattern.Implementation.Strategies;

namespace StrategyPattern.Implementation.Context
{
    public class State
    {
        private IPropsBuilderStrategy _propsBuilderStrategy;
            
        public State(IPropsBuilderStrategy propsBuilderStrategy)
        {
            _propsBuilderStrategy = propsBuilderStrategy;
        }

        public string BuildProps()
        {
            return _propsBuilderStrategy.BuildProps();
        }
    }
}
