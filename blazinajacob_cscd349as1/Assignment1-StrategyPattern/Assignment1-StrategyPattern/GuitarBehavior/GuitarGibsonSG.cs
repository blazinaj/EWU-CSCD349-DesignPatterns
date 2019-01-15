using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.SoloBehavior
{
    public class GuitarGibsonSG : IGuitarBehavior
    {
        public string PlayGuitar()
        {
            return "Plays Gibson SG Guitar";
        }
    }
}
