using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class RedBall : Ball
    {
        private Tree tree;
        private int cost = 1;

        public RedBall(Tree tree)
        {
            this.tree = tree;
        }
        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Red Ball";
        }
    }
}
