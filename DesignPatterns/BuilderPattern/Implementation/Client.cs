using BuilderPattern.Implementation.Builders;
using BuilderPattern.Implementation.ConcreteBuilders;
using BuilderPattern.Implementation.Director;
using BuilderPattern.Implementation.Products;

namespace BuilderPattern.Implementation
{
    class Client
    {
        static void Main(string[] args)
        {
            RetrieverBuilder toteRetrieverBuilder = new ToteRetrieverBuilder();
            RetrieverBuilder betSafeRetrieverBuilder = new BetSafeRetrieverBuilder();

            RetrieverMaker toteRetrieverMaker = new RetrieverMaker(toteRetrieverBuilder);
            RetrieverMaker betSafeRetrieverMaker = new RetrieverMaker(betSafeRetrieverBuilder);

            toteRetrieverMaker.BuildRetriever();
            Retriever toteRetriever = toteRetrieverMaker.GetRetriever();
            betSafeRetrieverMaker.BuildRetriever();
            Retriever betSafeRetriever = betSafeRetrieverMaker.GetRetriever();

            toteRetriever.FetchData();
            System.Console.WriteLine();
            betSafeRetriever.FetchData();
        }
    }
}
