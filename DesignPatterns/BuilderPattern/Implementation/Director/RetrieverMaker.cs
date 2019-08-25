using BuilderPattern.Implementation.Builders;
using BuilderPattern.Implementation.Products;

namespace BuilderPattern.Implementation.Director
{
    public class RetrieverMaker
    {
        private RetrieverBuilder _retrieverBuilder;

        public RetrieverMaker(RetrieverBuilder retrieverBuilder)
        {
            _retrieverBuilder = retrieverBuilder;
        }

        public void BuildRetriever()
        {
            _retrieverBuilder.CreateNewRetriever();
            _retrieverBuilder.SetRetrieverIdentity();
            _retrieverBuilder.SetDebounce();
            _retrieverBuilder.AddSportType();
            _retrieverBuilder.AddEndpoints();
        }

        public Retriever GetRetriever()
        {
            return _retrieverBuilder.GetRetriever();
        }
    }
}
