namespace GildedRose.Console.QualityStrategies
{
    public class IncreaseQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50) item.Quality = item.Quality + 1;                

            if (item.SellIn < 0 && item.Quality <50) item.Quality = item.Quality + 1;
        }
    }
}
