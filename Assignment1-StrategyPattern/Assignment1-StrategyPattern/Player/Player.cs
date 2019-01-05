using Assignment1_StrategyPattern.SoloBehavior;
using Assignment1_StrategyPattern.GuitarBehavior;
using System;
namespace Assignment1_StrategyPattern
{
    public abstract class Player
    {
        public ISoloBehavior SoloBehavior { get; set; }
        public IGuitarBehavior GuitarBehavior { get; set; }
        
        public Player()
        {
            SoloBehavior = new SoloNoTalent();
            GuitarBehavior = new GuitarNoTalent();
        }

        public Player(ISoloBehavior sb, IGuitarBehavior gb)
        {
            SoloBehavior = sb;
            GuitarBehavior = gb;
        }

        public string PerformSolo()
        {
            return SoloBehavior.PerformSolo();
        }

        public string PlayGuitar()
        {
            return GuitarBehavior.PlayGuitar();
        }

        public abstract void ShoutName();
    }
}
