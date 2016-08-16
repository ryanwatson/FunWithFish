using System.Collections.Generic;
using System.Linq;

namespace TheFish
{
    public class FishTank : IFishTank
    {
        private readonly IList<IFish> _fishList;

        public FishTank()
        {
            _fishList = new List<IFish>();
        }

        public void AddFish(IFish fish)
        {
            _fishList.Add(fish);
        }

        public decimal Feed()
        {
            return _fishList.Sum(e => e.FoodInGrams);
        }

        public void RemoveFish(IFish fish)
        {
            _fishList.Remove(fish);
        }
    }
}
