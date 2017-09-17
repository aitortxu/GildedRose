using System;
using System.Collections.Generic;
using Xunit;
using GildedRose.Console;

namespace GildedRose.Tests
{
    using FluentAssertions;

    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheValues_WhenOneDayPass()
        {
            var inventory = new ItemsInventory()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                            new Item
                                {
                                    Name = "Backstage passes to a TAFKAL80ETC concert",
                                    SellIn = 15,
                                    Quality = 20
                                },
                            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                        }

            };

            inventory.UpdateQuality();

            inventory.Items[0].Quality.Should().Be(19);
            inventory.Items[1].Quality.Should().Be(1);
            inventory.Items[2].Quality.Should().Be(6);
            inventory.Items[3].Quality.Should().Be(80);
            inventory.Items[4].Quality.Should().Be(21);
            inventory.Items[5].Quality.Should().Be(5);
        }

        [Fact]
        public void TestTheValues_WhenTwentyDaysPass()
        {
            var inventory = new ItemsInventory()
            {
                Items = new List<Item>
                        {
                            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                            new Item
                                {
                                    Name = "Backstage passes to a TAFKAL80ETC concert",
                                    SellIn = 15,
                                    Quality = 20
                                },
                            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                        }

            };

            for (int i = 1; i < 20; i++)
            {
                inventory.UpdateQuality();

            }

            inventory.Items[0].Quality.Should().Be(0);
            inventory.Items[0].SellIn.Should().Be(-9);

            inventory.Items[1].Quality.Should().Be(36);
            inventory.Items[1].SellIn.Should().Be(-17);

            inventory.Items[2].Quality.Should().Be(0);
            inventory.Items[2].SellIn.Should().Be(-14);

            inventory.Items[3].Quality.Should().Be(80);
            inventory.Items[3].SellIn.Should().Be(0);

            inventory.Items[4].Quality.Should().Be(0);
            inventory.Items[4].SellIn.Should().Be(-4);

            inventory.Items[5].Quality.Should().Be(0);
            inventory.Items[5].SellIn.Should().Be(-16);
        }
    }
}