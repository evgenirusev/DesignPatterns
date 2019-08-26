namespace Implementation
{
    public class IsSelectedDecorator : PropsBuilderDecorator
    {
        public IsSelectedDecorator(IPropsBuilder propsBuilder) : base(propsBuilder)
        { }

        public override string CenterPropsBuilder()
        {
            return base.CenterPropsBuilder() + ", isSelected: false";
        }
    }
}
