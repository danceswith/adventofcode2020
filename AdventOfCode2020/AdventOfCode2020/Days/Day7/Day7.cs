using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day7
{
    public class Day7
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day7\input.txt");

            var bags = new List<Bag>();

            foreach(var line in file)
            {
                bags.Add(new Bag(line));
            }

            bags.ForEach(b => b.SetInnerBagObjects(bags));

            var count = 0;

            foreach(var bag in bags)
            {
                if (bag.CanBagContain("shiny gold")) count++;
            }

            Console.WriteLine(count);
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day7\input.txt");

            var bags = new List<Bag>();

            foreach (var line in file)
            {
                bags.Add(new Bag(line));
            }

            bags.ForEach(b => b.SetInnerBagObjects(bags));

            var shinyGoldBag = bags.Single(b => b.BagType == "shiny gold");

            Console.WriteLine(shinyGoldBag.SumContainingBags());
        }
    }
}
