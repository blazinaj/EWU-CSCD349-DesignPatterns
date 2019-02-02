using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator.HolidayDecoration
{
    public class Star : HolidayItem
    {
        public Tree tree;
        public int cost = 4;
        public string Des;
        public Star(Tree tree)
        {
            this.tree = tree;
            if (tree.GetDescription().Contains("Star"))
            {
                Des = tree.GetDescription();
            }
            else
            Des = tree.GetDescription() + ", Star";
        }

        public override int Cost()
        {

            if (tree.GetDescription().Contains("Star"))
            {
                return tree.Cost();
            }
            else
                return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return Des;
        }
    }
}
