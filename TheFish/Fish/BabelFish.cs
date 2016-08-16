namespace TheFish.Fish
{
    public class BabelFish : IFish
    {
        public string Name { get; set; }
        public decimal FoodInGrams { get { return 51.88m; } }
    }
}