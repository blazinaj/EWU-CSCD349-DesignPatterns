using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Lights : HolidayItem
    {
        private Tree tree;
        private int cost = 5;

        public Lights(Tree tree)
        {
            this.tree = tree;
        }

        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Lights";
        }
    }
}
