using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class DouglasFir : Tree
    {
        private int cost = 30;
        public DouglasFir()
        {

        }

        public override string GetDescription()
        {
            return "Douglas Fir";
        }

        public override int Cost()
        {
            return cost;
        }
    }
}
