using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.SoloBehavior
{
    public class GuitarFenderTelecaster : IGuitarBehavior
    {
        public string PlayGuitar()
        {
            return "Plays Fender Telecaster Guitar";
        }
    }
}
