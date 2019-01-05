using Assignment1_StrategyPattern.GuitarBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.SoloBehavior
{
    public class SoloNoTalent : ISoloBehavior
    {
        public String PerformSolo()
        {
            return "Can't perform a solo due to lack of talent";
        }
    }
}
