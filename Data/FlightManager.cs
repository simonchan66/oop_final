using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorHybridApp2.Pages;

namespace BlazorHybridApp2.Data
{
    public class FlightManager
    {

        //public Flight FindFlightByCode(string code)
        //{
        //    // Find and return flight by code 
        //}

        public FlightManager()
        {
            // Constructor
        }

        public IList<Flight> Flights { get; }

        public const string FLIGHTS_FILE = "flights.json";

        protected List<Flight> _flights;

        protected void LoadFlights()
        {
            // Load flights from file
        }

    }
}
