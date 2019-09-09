using System;

namespace SingletonPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            var repository = Repository.Instance();
            Console.WriteLine(repository.GetByUserId("5"));
        }
    }
}
