using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace GildedRose.Core.Specs
{
    public class GildedRoseSpecs
    {
        [Fact]
        public void Test()
        {
            List<Item> items = new GildedRose().MakeItems();
            
            
        }
    }
}