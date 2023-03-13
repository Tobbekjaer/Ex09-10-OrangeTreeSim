using OrangeTreeSim; 

namespace OrangeTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
            // Start an orange tree
            orangeTree = new OrangeTree();

            // Setting Age property value to 0 before running tests
            int expectedValueAge = 0;
            orangeTree.Age = expectedValueAge;

            // Setting Height property value to 6 before running tests
            int expectedValueHeight = 6;
            orangeTree.Height = expectedValueHeight;

            // Setting TreeAlive property value to 'true' before running tests
            bool expectedValueTreeAlive = true;
            orangeTree.TreeAlive = expectedValueTreeAlive;

        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(1, orangeTree.Age);
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(8, orangeTree.Height);
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++) {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive);
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges);

        }
        [TestMethod]
        public void ShouldIncreaseFruitProductionBy5PiecesEachYearAfterMaturity()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            Assert.AreEqual(10, orangeTree.NumOranges);

        }
        [TestMethod]
        public void ShouldCountNumberOfOrangesEatenThisYear()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);

            Assert.AreEqual(1, orangeTree.GetOrangesEaten());

            orangeTree.EatOrange(3);
            Assert.AreEqual(4, orangeTree.GetOrangesEaten());

            Assert.AreEqual(1, orangeTree.NumOranges);
        }
        [TestMethod]
        public void OrangesEatenOneYearPasses()
        {
            //Act
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);
            orangeTree.EatOrange(3);
            orangeTree.OneYearPasses();
            //Assert
            Assert.AreEqual(4, orangeTree.GetOrangesEaten());
            Assert.AreEqual(10, orangeTree.NumOranges);
        }

        [TestMethod]
        public void DeadTreeDoNotGrowAndProduceFruit()
        {
            //Act
            for (int i = 1; i <= 80; i++) {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(81, orangeTree.Age);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(82, orangeTree.Age);

        }

    }

}