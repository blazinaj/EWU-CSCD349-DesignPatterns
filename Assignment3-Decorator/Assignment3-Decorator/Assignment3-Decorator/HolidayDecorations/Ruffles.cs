using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Ruffles : HolidayItem
    {
        public Tree tree;
        public int cost = 1;
        public Ruffles(Tree tree)
        {
            this.tree = tree;
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Ruffles";
        }

        public override int Cost()
        {
            return cost + tree.Cost();
        }
    }
}
