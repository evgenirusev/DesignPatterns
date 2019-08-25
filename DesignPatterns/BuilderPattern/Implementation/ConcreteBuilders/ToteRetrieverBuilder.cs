using BuilderPattern.Implementation.Builders;
using BuilderPattern.Implementation.Emum;

namespace BuilderPattern.Implementation.ConcreteBuilders
{
    public class ToteRetrieverBuilder : RetrieverBuilder
    {
        public override void AddEndpoints()
        {
            _retriever.EventsEndpoint = "https://tote.events";
            _retriever.SportsEndpoint = "https://tote.sports";
            _retriever.CoefficientsEndpoint = "https://tote.coefficients";
        }

        public override void AddSportType()
        {
            _retriever.TypeOfSport = SportType.HorseRacing;
        }

        public override void SetDebounce()
        {
            _retriever.IsDebounceEnabled = false;
        }

        public override void SetRetrieverIdentity()
        {
            _retriever.RetrieverId = 1;
            _retriever.RetrieverName = "ToteRetriever";
        }
    }
}
