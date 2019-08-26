namespace Implementation
{
    public class PropsBuilderDecorator : IPropsBuilder
    {
        protected IPropsBuilder _propsBuilder;

        public PropsBuilderDecorator(IPropsBuilder propsBuilder)
        {
            _propsBuilder = propsBuilder;
        }

        public virtual string CenterPropsBuilder()
        {
            return _propsBuilder.CenterPropsBuilder();
        }
    }
}
