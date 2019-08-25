using BuilderPattern.Implementation.Products;

namespace BuilderPattern.Implementation.Builders
{
    public abstract class RetrieverBuilder
    {
        protected Retriever _retriever;

        public Retriever GetRetriever()
        {
            return _retriever;
        }

        public void CreateNewRetriever()
        {
            _retriever = new Retriever();
        }

        public abstract void SetRetrieverIdentity();
        public abstract void AddEndpoints();
        public abstract void AddSportType();
        public abstract void SetDebounce();
    }
}
