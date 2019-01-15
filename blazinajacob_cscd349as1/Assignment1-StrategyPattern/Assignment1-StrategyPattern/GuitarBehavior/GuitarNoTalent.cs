using Assignment1_StrategyPattern.SoloBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.GuitarBehavior
{
    public class GuitarNoTalent : IGuitarBehavior
    {
        public string PlayGuitar()
        {
            return "Can't play the guitar due to lack of talent";
        }
    }
}
