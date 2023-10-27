using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp2.Data
{
    public class AirportManager
    {

        public AirportManager()
        {
            // Constructor
        }

        public IList<Airport> Airports { get; }

        public const string AIRPORTS_FILE = "airports.json";

        protected List<Airport> _airports;

        protected void LoadAirports()
        {
            // Load airports data from file
        }

    }
}
