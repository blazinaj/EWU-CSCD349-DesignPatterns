using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class FraserFir : Tree
    {
        public int cost = 35;

        public FraserFir()
        {
        }

        public override int Cost()
        {
            return cost;
        }

        public override string GetDescription()
        {
            return "Fraser Fir";
        }
    }
}
