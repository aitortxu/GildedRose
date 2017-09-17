namespace GildedRose.Console.SellInStrategies
{
    public class StandardSellInUpdateStrategy : ISellInUpdateStrategy
    {
        public void UpdateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
