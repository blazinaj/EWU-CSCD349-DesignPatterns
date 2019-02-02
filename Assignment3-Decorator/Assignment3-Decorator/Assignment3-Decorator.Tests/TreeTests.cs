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

            Assert.AreEqual("Douglas Fir, Ribbons costs: 32 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_Tree_Multiple_Success()
        {
            Tree tree = new BalsamFir();

            tree = new Lights(tree);
            tree = new Ribbons(tree);
            tree = new LEDs(tree);

            Assert.AreEqual("Balsam Fir, Lights, Ribbons, LEDs costs: 42 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_With_Everything_Success()
        {
            Tree tree = new ColoradoBlueSpruce();

            tree = new LEDs(tree);
            tree = new Lights(tree);
            tree = new Ribbons(tree);
            tree = new Ruffles(tree);

            Assert.AreEqual("Colorado Blue Spruce, LEDs, Lights, Ribbons, Ruffles costs: 68 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_With_Star_Works_Once()
        {
            Tree tree = new FraserFir();

            tree = new LEDs(tree);
            tree = new Star(tree);

            Assert.AreEqual("Fraser Fir, LEDs, Star costs: 49 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }

        [TestMethod]
        public void Decorate_With_Star_Twice_Doesnt_Add_Twice()
        {
            Tree tree = new BalsamFir();

            tree = new Lights(tree);
            tree = new Star(tree);
            tree = new Ruffles(tree);
            tree = new Star(tree);

            Assert.AreEqual("Balsam Fir, Lights, Star, Ruffles costs: 35 dollars", tree.GetDescription() + " costs: " + tree.Cost() + " dollars");
        }
    }
}
