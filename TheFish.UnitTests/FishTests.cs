using NUnit.Framework;
using TheFish.Fish;

namespace TheFish.UnitTests
{
    [TestFixture]
    public class FishTests
    {

        [Test]
        public void Given_Multiple_Fish_Ensure_Grams()
        {
            var fishTank = new FishTank();
            var goldFish = new GoldFish { Name = "Gary" };
            var angelFish = new AngelFish { Name = "Steve" };
            var babelFish = new BabelFish { Name = "Mr Fish" };

            fishTank.AddFish(goldFish);
            fishTank.AddFish(angelFish);
            fishTank.AddFish(babelFish);

            decimal howMuchToFeed = fishTank.Feed();
            Assert.AreEqual(howMuchToFeed, goldFish.FoodInGrams + angelFish.FoodInGrams + babelFish.FoodInGrams);
        }

        [Test]
        public void Given_Fish_Are_Removed_Change_Feeding()
        {
            var fishTank = new FishTank();
            var angelFish = new AngelFish { Name = "Steve" };
            var babelFish = new BabelFish { Name = "Mr Fish" };

            fishTank.AddFish(angelFish);
            fishTank.AddFish(babelFish);

            decimal howMuchToFeed1 = fishTank.Feed();
            fishTank.RemoveFish(babelFish);
            decimal howMuchToFeed2 = fishTank.Feed();

            Assert.Less(howMuchToFeed2, howMuchToFeed1);
        }

        [Test]
        public void Given_Fish_Are_Add_Change_Feeding()
        {
            var fishTank = new FishTank();
            var angelFish = new AngelFish { Name = "Steve" };
            var babelFish = new BabelFish { Name = "Mr Fish" };

            fishTank.AddFish(angelFish);
            fishTank.AddFish(babelFish);

            decimal howMuchToFeed1 = fishTank.Feed();
            fishTank.AddFish(babelFish);
            decimal howMuchToFeed2 = fishTank.Feed();

            Assert.Greater(howMuchToFeed2, howMuchToFeed1);
        }
    }
}
