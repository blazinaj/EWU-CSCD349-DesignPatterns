using Assignment1_StrategyPattern.SoloBehavior;
using Assignment1_StrategyPattern.GuitarBehavior;
using System;
namespace Assignment1_StrategyPattern
{
    public abstract class Player
    {
        private ISoloBehavior SoloBehavior { get; set; }
        private IGuitarBehavior GuitarBehavior { get; set; }
        
        protected Player()
        {
            SoloBehavior = new SoloNoTalent();
            GuitarBehavior = new GuitarNoTalent();
        }

        protected Player(ISoloBehavior sb, IGuitarBehavior gb)
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

        public void SwapGuitarBehavior(IGuitarBehavior gb)
        {
            GuitarBehavior = gb;
        }

        public void SwapSoloBehavior(ISoloBehavior sb)
        {
            SoloBehavior = sb;
        }

        public abstract void ShoutName();
    }
}
