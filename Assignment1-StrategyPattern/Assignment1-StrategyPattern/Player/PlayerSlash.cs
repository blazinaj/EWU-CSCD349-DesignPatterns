using Assignment1_StrategyPattern.GuitarBehavior;
using Assignment1_StrategyPattern.SoloBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern
{
    public class PlayerSlash : Player
    {
        public PlayerSlash()
        {
        }

        public PlayerSlash(ISoloBehavior sb, IGuitarBehavior gb) : base(sb, gb)
        {
        }

        public override void ShoutName()
        {
            Console.WriteLine("I'M SLASH!!!!");
        }
    }
}
