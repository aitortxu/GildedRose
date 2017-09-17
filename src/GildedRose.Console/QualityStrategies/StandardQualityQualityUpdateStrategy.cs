namespace GildedRose.Console.QualityStrategies
{
    public class StandardQualityQualityUpdateStrategy : IQualityUpdateStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = item.Quality - 1;
        }
    }
}
