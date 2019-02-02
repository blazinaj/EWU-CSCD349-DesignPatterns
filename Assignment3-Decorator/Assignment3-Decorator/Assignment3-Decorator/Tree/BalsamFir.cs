using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class BalsamFir : Tree
    {
        public int cost = 25;
        public BalsamFir()
        {
        }

        public override string GetDescription()
        {
            return "Balsam Fir";
        }

        public override int Cost()
        {
            return this.cost;
        }
    }
}
