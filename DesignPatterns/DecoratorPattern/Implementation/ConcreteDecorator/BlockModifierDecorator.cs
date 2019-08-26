namespace Implementation
{
    public class BlockModifierDecorator : PropsBuilderDecorator
    {
        public BlockModifierDecorator(IPropsBuilder propsBuilder) : base(propsBuilder)
        { }

        public override string CenterPropsBuilder()
        {
            return base.CenterPropsBuilder() + ", blockModifier: 100";
        }
    }
}
