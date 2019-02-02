using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class SilverBall : Ball
    {
        private Tree tree;
        private int cost = 3;

        public SilverBall(Tree tree)
        {
            this.tree = tree;
        }
        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Silver Ball";
        }
    }
}
