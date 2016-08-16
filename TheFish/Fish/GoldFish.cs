namespace TheFish.Fish
{
    public class GoldFish : IFish
    {
        public string Name { get; set; }
        public decimal FoodInGrams { get { return 5.5m; } }
    }
}