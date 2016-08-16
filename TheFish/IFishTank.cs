namespace TheFish
{
    public interface IFishTank
    {
        void AddFish(IFish fish);
        void RemoveFish(IFish fish);
        decimal Feed();
    }
}