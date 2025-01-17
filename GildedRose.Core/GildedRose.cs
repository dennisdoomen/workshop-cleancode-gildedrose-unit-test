using System;
using System.Collections.Generic;

namespace GildedRose;

public class GildedRose
{
    public static void Main(string[] args)
    {
        var gildedRose = new GildedRose();
        gildedRose.UpdateQuality(gildedRose.MakeItems());
    }

    public List<Item> MakeItems()
    {
        return new List<Item>
        {
            new("+5 Dexterity Vest", 10, 20),
            new("Aged Brie", 2, 0),
            new("Elixir of the Mongoose", 5, 7),
            new("Sulfuras, Hand of Ragnaros", 0, 80),
            new("Backstage passes to a TAFKAL80ETC concert", 15, 20),
            new("Conjured Mana Cake", 3, 6)
        };
    }

    public void UpdateQuality(List<Item> list)
    {
        var items = list;
        foreach (var item in items)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                        item.Quality = item.Quality - 1;
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                    {
                        if (item.SellIn < 11)
                            if (item.Quality < 50)
                                item.Quality = item.Quality + 1;

                        if (item.SellIn < 6)
                            if (item.Quality < 50)
                                item.Quality = item.Quality + 1;
                    }
                }
            }

            if (!item.Name.Equals("Sulfuras, Hand of Ragnaros")) item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                                item.Quality = item.Quality - 1;
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50) item.Quality = item.Quality + 1;
                }
            }
        }
    }
}