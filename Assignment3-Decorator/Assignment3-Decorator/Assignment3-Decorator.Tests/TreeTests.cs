using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3_Decorator;
using Assignment3_Decorator.HolidayDecoration;

namespace Assignment3_Decorator.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Create_New_Tree_Success()
        {
            Tree tree = new DouglasFir();

            Assert.AreEqual(30, tree.Cost());
        }

        [TestMethod]
        public void Decorate_Tree_Once_Success()
        {
            Tree tree = new DouglasFir();

            tree = new Ribbons(tree);

            Assert.AreEqual("Douglas Fir costs: 32 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_Tree_Multiple_Success()
        {
            Tree tree = new BalsamFir();

            tree = new Lights(tree);
            tree = new Ribbons(tree);
            tree = new LEDs(tree);

            Assert.AreEqual("Balsam Fir costs: 42 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_With_Everything_Success()
        {
            Tree tree = new ColoradoBlueSpruce();

            tree = new LEDs(tree);
            tree = new Lights(tree);
            tree = new Ribbons(tree);
            tree = new Ruffles(tree);

            Assert.AreEqual("Colorado Blue Spruce costs: 68 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }
    }
}
