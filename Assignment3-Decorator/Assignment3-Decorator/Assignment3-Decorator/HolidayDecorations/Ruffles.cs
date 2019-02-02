using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Ruffles : HolidayItem
    {
        private Tree tree;
        public int cost = 1;
        public Ruffles(Tree tree)
        {
            this.tree = tree;
        }

        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Ruffles";
        }
    }
}
