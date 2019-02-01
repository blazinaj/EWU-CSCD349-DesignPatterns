using System;

namespace Assignment3_Decorator
{
    public abstract class Tree
    {
        protected string Description = "Unknown Tree";
        protected bool HasStar = false;

        public string GetDescription()
        {
            return Description;
        }

        public string GetStar()
        {
            return HasStar ? "Tree Already Has A Star" : "Star";
        }

        public abstract int Cost();
    }
}
