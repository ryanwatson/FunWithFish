namespace TheFish.Fish
{
    public class AngelFish : IFish
    {
        public string Name { get; set; }
        public decimal FoodInGrams { get { return 8m; } }
    }
}