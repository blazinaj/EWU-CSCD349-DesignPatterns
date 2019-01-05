using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.GuitarBehavior
{
    public class SoloGuitarOnFire : ISoloBehavior
    {
        public String PerformSolo()
        {
            return "Lights the guitar on fire";
        }
    }
}
