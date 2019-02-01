using System;

namespace Assignment3_Decorator
{
    public abstract class Tree
    {
        public int TotalCost = 0;
        public string Description = "unknown Tree";

        public string GetDescription()
        {
            return Description;
        }

        public abstract int Cost();
    }
}
