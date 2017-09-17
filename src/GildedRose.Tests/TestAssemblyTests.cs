using System;
using System.Collections.Generic;
using Xunit;
using GildedRose.Console;

namespace GildedRose.Tests
{
    using FluentAssertions;

    using GildedRose.Console.QualityStrategies;
    using GildedRose.Console.SellInStrategies;

    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheValues_WhenOneDayPass()
        {
            var inventory = GetItemsInventory();

            inventory.UpdateQuality();

            inventory.Items[0].Quality.Should().Be(19);
            inventory.Items[0].SellIn.Should().Be(9);
            inventory.Items[1].Quality.Should().Be(1);
            inventory.Items[2].Quality.Should().Be(6);
            inventory.Items[3].Quality.Should().Be(80);
            inventory.Items[4].Quality.Should().Be(21);
            inventory.Items[5].Quality.Should().Be(5);
        }

        private static ItemsInventory GetItemsInventory()
        {
            var inventory = new ItemsInventory()
            {
                Items = new List<Item>
                    {   new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                        { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                        new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                        { Name = "Aged Brie", SellIn = 2, Quality = 0},
                        new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                        { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                        new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                        { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                        new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                            {
                                Name = "Backstage passes to a TAFKAL80ETC concert",
                                SellIn = 15,
                                Quality = 20
                            },
                        new Item(new StandardQualityQualityUpdateStrategy(), new StandardSellInUpdateStrategy())
                        { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                    }
            };
            return inventory;
        }

        [Fact]
        public void TestTheValues_WhenTwoDaysPass()
        {
            var inventory = GetItemsInventory();

            inventory.UpdateQuality();
            inventory.UpdateQuality();

            inventory.Items[0].Quality.Should().Be(18);
            inventory.Items[1].Quality.Should().Be(2);
            inventory.Items[2].Quality.Should().Be(5);
            inventory.Items[3].Quality.Should().Be(80);
            inventory.Items[4].Quality.Should().Be(22);
            inventory.Items[5].Quality.Should().Be(4);
        }
    }
}