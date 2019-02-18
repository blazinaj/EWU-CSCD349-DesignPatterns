using Assignment2_ObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment2_Observer
{
    [TestClass]
    public class ObserverPatternTests
    {
        [TestMethod]
        public void Create_EyeOfSauron_Success()
        {
            EyeofSauron eye = new EyeofSauron();
            Assert.AreEqual(eye, typeof(EyeofSauron));
        }

        [TestMethod]
        public void Register_Saruman()
        {
            EyeofSauron eye = new EyeofSauron();
            BadGuy saruman = new BadGuy(eye, "Saruman");

            Assert.IsTrue(eye.Observers.Contains(typeof(BadGuy));
        }

        [TestMethod]
        public void UnRegister_Saruman()
        {
            EyeofSauron eye = new EyeofSauron();
            BadGuy saruman = new BadGuy(eye, "Saruman");
        }
    }
}
