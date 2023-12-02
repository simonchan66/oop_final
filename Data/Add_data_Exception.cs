using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp2.Data
{
    public class Add_data_Exception : Exception
    {
        public Add_data_Exception()
          : base("Unable to add data")
        {
        }

        public Add_data_Exception(string message)
          : base(message)
        {
        }
    }
}
