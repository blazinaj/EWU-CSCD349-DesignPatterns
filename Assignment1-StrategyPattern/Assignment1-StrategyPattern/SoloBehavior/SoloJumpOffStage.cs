using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern.GuitarBehavior
{
    public class SoloJumpOffStage : ISoloBehavior
    {
        public String PerformSolo()
        {
            return "Jumps off the stage";
        }
    }
}
