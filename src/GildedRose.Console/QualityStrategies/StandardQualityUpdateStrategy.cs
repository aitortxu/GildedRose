namespace GildedRose.Console.QualityStrategies
{
    public class StandardQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;                
            }

            if (item.SellIn < 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 1;
            }

        }
    }
}
