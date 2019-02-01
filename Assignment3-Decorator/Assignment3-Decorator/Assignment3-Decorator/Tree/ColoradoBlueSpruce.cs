using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class ColoradoBlueSpruce : Tree
    {
        public int cost = 50;
        public ColoradoBlueSpruce()
        {
            Description = "ColoradoBlueSpruce";
        }

        public override int Cost()
        {
            return cost;
        }
    }
}
