using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class DouglasFir : Tree
    {
        private int cost = 30;
        string description = "Douglas Fir";
        public DouglasFir()
        {
            Description = "Douglas Fir";
        }

        public override int Cost()
        {
            return cost;
        }
    }
}
