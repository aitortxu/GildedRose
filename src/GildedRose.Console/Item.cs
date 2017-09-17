namespace GildedRose.Console
{
    using GildedRose.Console.QualityStrategies;
    using GildedRose.Console.SellInStrategies;

    public class Item
    {
        private readonly IQualityUpdateStrategy qualityUpdateStrategy;

        private readonly  ISellInUpdateStrategy sellInUpdateStrategy;

        public Item(IQualityUpdateStrategy qualityUpdateStrategy, ISellInUpdateStrategy sellInUpdateStrategy)
        {
            this.qualityUpdateStrategy = qualityUpdateStrategy;
            this.sellInUpdateStrategy = sellInUpdateStrategy;
        }

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
        
        public void UpdateStatus()
        {
            this.sellInUpdateStrategy.UpdateSellIn(this);
            this.qualityUpdateStrategy.UpdateQuality(this);
        }
    }
}