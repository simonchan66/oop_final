using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorHybridApp2.Pages;
namespace BlazorHybridApp2.Data
{
    public class Reservation
    {
        public string Code { get; set; }
        public Flight Flight { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }

        public Reservation(Flight flight, string name, string citizenship)
        {
            Flight = flight;
            Name = name;
            Citizenship = citizenship;
            Code = GenerateCode(flight);
        }

        private string GenerateCode(Flight flight)
        {
            Random random = new Random();
            char letter = flight.AirlineCode[0];
            int digits = random.Next(1000, 9999); 
            return $"{letter}{digits:D4}";
        }
    }
}