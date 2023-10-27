using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp2.Data
{
    public class AirlineManager
    {

        public AirlineManager()
        {
            // Constructor 
        }

        public IList<Airline> Airlines { get; }

        public const string AIRLINES_FILE = "airlines.json";

        //public Airline FindAirline(string code)
        //{

        //    // Find and return airline by code
        //}

        protected List<Airline> _airlines;

        protected void LoadAirlines()
        {
            // Load airlines from file 
        }

    }
}
