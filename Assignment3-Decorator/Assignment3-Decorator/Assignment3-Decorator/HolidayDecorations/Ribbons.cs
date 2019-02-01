using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Ribbons : HolidayItem
    {
        private Tree tree;
        private int cost = 2;
        public Ribbons(Tree tree)
        {
            this.tree = tree;
        }
        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Ribbons";
        }
    }
}
