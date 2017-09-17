using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {        
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

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
                System.Console.WriteLine(string.Format("Iteration {0} -----------------------", i) );
                inventory.UpdateQuality();

                foreach (var item in inventory.Items)
                {
                    System.Console.WriteLine(string.Format("Updated quality of {0} is {1}", item.Name, item.Quality));
                    System.Console.WriteLine(string.Format("Updated sellin of {0} is {1}", item.Name, item.SellIn));
                }
            }


            System.Console.ReadKey();

        }
    }
}
