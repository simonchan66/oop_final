﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridApp2.Data
{
    public class Airline
    {

        public Airline(string code, string name)
        {
            // Constructor 
        }

        public string Code { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return "testing";
            // Format airline for string representation
        }

    }
}