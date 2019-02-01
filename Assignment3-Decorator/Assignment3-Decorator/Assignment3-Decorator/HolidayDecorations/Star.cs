using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Star : HolidayItem
    {
        public Tree tree;
        public int cost = 1;
        public Star(Tree tree)
        {
            this.tree = tree;
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Star";
        }

        public override int Cost()
        {
            return cost + tree.Cost();
        }
    }
}
