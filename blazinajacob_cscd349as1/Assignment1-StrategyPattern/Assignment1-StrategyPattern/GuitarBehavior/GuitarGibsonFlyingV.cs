using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.SoloBehavior
{
    public class GuitarGibsonFlyingV : IGuitarBehavior
    {
        public string PlayGuitar()
        {
            return "Plays Gibson Flying V Guitar";
        }
    }
}
