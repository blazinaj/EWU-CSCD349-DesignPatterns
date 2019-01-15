using Assignment1_StrategyPattern.GuitarBehavior;
using Assignment1_StrategyPattern.SoloBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_StrategyPattern
{
    public class PlayerAngusYoung : Player
    {
        public PlayerAngusYoung()
        {}

        public PlayerAngusYoung(ISoloBehavior sb, IGuitarBehavior gb) : base(sb, gb)
        {}

        public override void ShoutName()
        {
            Console.WriteLine("I'M ANGUS YOUNG!!!!");
        }
    }
}
