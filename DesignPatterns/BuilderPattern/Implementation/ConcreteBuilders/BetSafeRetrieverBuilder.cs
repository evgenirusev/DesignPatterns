using BuilderPattern.Implementation.Builders;
using BuilderPattern.Implementation.Emum;

namespace BuilderPattern.Implementation.ConcreteBuilders
{
    public class BetSafeRetrieverBuilder : RetrieverBuilder
    {
        public override void AddEndpoints()
        {
            _retriever.EventsEndpoint = "https://betsafe.events";
            _retriever.SportsEndpoint = "https://betsafe.sports";
            _retriever.CoefficientsEndpoint = "https://betsafe.coefficients";
        }

        public override void AddSportType()
        {
            _retriever.TypeOfSport = SportType.Football;
        }

        public override void SetDebounce()
        {
            _retriever.IsDebounceEnabled = true;
        }

        public override void SetRetrieverIdentity()
        {
            _retriever.RetrieverId = 2;
            _retriever.RetrieverName = "BetSafeRetriever";
        }
    }
}
