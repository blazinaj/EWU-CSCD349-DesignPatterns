using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class DouglasFir : Tree
    {
        public int cost = 30;
        public DouglasFir()
        {
            //How do I override the parent class Property called "Description"??
            Description = "Douglas Fir";
        }

        public override int Cost()
        {
            return cost;
        }
    }
}
