namespace GildedRose.Console.QualityStrategies
{
    public class BackstageQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = item.Quality + 1;

            if (item.SellIn <= 10) item.Quality = item.Quality + 1;

            if (item.SellIn <= 5) item.Quality = item.Quality + 1;

            if (item.SellIn < 0) item.Quality = 0;
            
            if (item.Quality > 50) item.Quality = 50;
        }
    }
}
