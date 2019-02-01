using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Decorator
{
    public abstract class HolidayItem : Tree
    {
        public abstract new string GetDescription();
    }
}
