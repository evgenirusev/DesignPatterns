using BuilderPattern.Implementation.Emum;
using System;

namespace BuilderPattern.Implementation.Products
{
    public class Retriever
    {
        public int RetrieverId { get; set; }
        public string RetrieverName { get; set; }
        public string EventsEndpoint { get; set; }
        public string SportsEndpoint { get; set; }
        public string CoefficientsEndpoint { get; set; }
        public bool IsDebounceEnabled { get; set; }
        public SportType TypeOfSport { get; set; }

        public void FetchData()
        {
            // simulate request...
            Console.WriteLine("{0} is creting a request...", RetrieverName);
            Console.WriteLine("Fetching Events From: " + EventsEndpoint);
            Console.WriteLine("Fetching Sports From: " + SportsEndpoint);
            Console.WriteLine("Fetching Coefficients From: " + CoefficientsEndpoint);
            Console.WriteLine("Is debounce enabled: " + IsDebounceEnabled);
            Console.WriteLine("Sport Type: " + TypeOfSport);
        }
        
    }
}
