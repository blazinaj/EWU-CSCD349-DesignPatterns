using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.GuitarBehavior
{
    public class SoloSmashGuitar : ISoloBehavior
    {
        public String PerformSolo()
        {
            return "Smashes the Guitar";
        }
    }
}
