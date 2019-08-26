namespace Implementation
{
    public class DictionaryDecorator : PropsBuilderDecorator
    {
        public DictionaryDecorator(IPropsBuilder propsBuilder) : base(propsBuilder)
        { }

        public override string CenterPropsBuilder()
        {
            return base.CenterPropsBuilder() + ", hasDictionary: true";
        }
    }
}
