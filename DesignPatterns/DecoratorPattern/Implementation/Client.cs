using System;

namespace Implementation
{
    public class Client
    {
        static void Main(string[] args)
        {
            // Create any possible permutation at runtime
            IPropsBuilder state = new State();
            state = new BlockModifierDecorator(state);
            state = new IsSelectedDecorator(state);
            state = new DictionaryDecorator(state);

            Console.WriteLine(state.CenterPropsBuilder());
        }
    }
}
