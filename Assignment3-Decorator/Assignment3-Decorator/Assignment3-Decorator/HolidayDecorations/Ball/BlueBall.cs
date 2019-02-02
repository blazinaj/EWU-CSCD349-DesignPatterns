using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public class BlueBall : Ball
    {
        private Tree tree;
        private int cost = 2;
        public BlueBall(Tree tree)
        {
            this.tree = tree;
        }
        public override int Cost()
        {
            return cost + tree.Cost();
        }

        public override string GetDescription()
        {
            return tree.GetDescription() + ", Blue Ball";
        }
    }
}
