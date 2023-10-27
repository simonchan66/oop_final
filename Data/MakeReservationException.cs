using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp2.Data
{
    public class MakeReservationException : Exception
    {
        public MakeReservationException()
          : base("Unable to make reservation.")
        {
        }

        public MakeReservationException(string message)
          : base(message)
        {
        }
    }
}
