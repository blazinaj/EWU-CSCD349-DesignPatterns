using Assignment1_StrategyPattern.GuitarBehavior;
using Assignment1_StrategyPattern.SoloBehavior;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1_StrategyPattern.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Create_New_Player_With_No_Talent_Success()
        {
            Player testPlayer = new PlayerJimiHendrix();
            Assert.AreEqual("Can't perform a solo due to lack of talent", testPlayer.PerformSolo());
            Assert.AreEqual("Can't play the guitar due to lack of talent", testPlayer.PlayGuitar());

            testPlayer = new PlayerAngusYoung();
            Assert.AreEqual("Can't perform a solo due to lack of talent", testPlayer.PerformSolo());
            Assert.AreEqual("Can't play the guitar due to lack of talent", testPlayer.PlayGuitar());

            testPlayer = new PlayerSlash();
            Assert.AreEqual("Can't perform a solo due to lack of talent", testPlayer.PerformSolo());
            Assert.AreEqual("Can't play the guitar due to lack of talent", testPlayer.PlayGuitar());
        }

        [TestMethod]
        public void Create_New_Player_With_Talent_Success()
        {
            Player jimi = new PlayerJimiHendrix(new SoloGuitarOnFire(), new GuitarFenderTelecaster());
            Player slash = new PlayerSlash(new SoloJumpOffStage(), new GuitarGibsonFlyingV());
            Player angus = new PlayerAngusYoung(new SoloSmashGuitar(), new GuitarGibsonSG());


            Assert.AreEqual("Lights the guitar on fire", jimi.PerformSolo());
            Assert.AreEqual("Plays Fender Telecaster Guitar", jimi.PlayGuitar());

            Assert.AreEqual("Jumps off the stage", slash.PerformSolo());
            Assert.AreEqual("Plays Gibson Flying V Guitar", slash.PlayGuitar());

            Assert.AreEqual("Smashes the Guitar", angus.PerformSolo());
            Assert.AreEqual("Plays Gibson SG Guitar", angus.PlayGuitar());

        }

        [TestMethod]
        public void Change_Player_Guitar_Success()
        {
            Player slash = new PlayerSlash();
            Player jimi = new PlayerJimiHendrix();
            Player angus = new PlayerAngusYoung();
            
            slash.SwapGuitarBehavior(new GuitarFenderTelecaster());
            jimi.SwapGuitarBehavior(new GuitarGibsonFlyingV());
            angus.SwapGuitarBehavior(new GuitarGibsonSG());
            
            Assert.AreEqual("Plays Fender Telecaster Guitar", slash.PlayGuitar());
            Assert.AreEqual("Plays Gibson Flying V Guitar", jimi.PlayGuitar());
            Assert.AreEqual("Plays Gibson SG Guitar", angus.PlayGuitar());
        }

        [TestMethod]
        public void Change_Player_Solo_Success()
        {
            Player slash = new PlayerSlash();
            Player jimi = new PlayerJimiHendrix();
            Player angus = new PlayerAngusYoung();
            
            slash.SwapSoloBehavior(new SoloGuitarOnFire());
            jimi.SwapSoloBehavior(new SoloJumpOffStage());
            angus.SwapSoloBehavior(new SoloSmashGuitar());

            Assert.AreEqual("Lights the guitar on fire", slash.PerformSolo());
            Assert.AreEqual("Jumps off the stage", jimi.PerformSolo());
            Assert.AreEqual("Smashes the Guitar", angus.PerformSolo());
        }
    }
}
