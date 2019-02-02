using System;

namespace Assignment3_Decorator
{
    public abstract class Tree
    {
        protected string Description = "Unknown Tree";
        public bool HasStar = false;
        public abstract string GetDescription();

        public abstract int Cost();
    }
}
