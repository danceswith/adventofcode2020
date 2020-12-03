using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2020.Days.Day3
{
    public class Day3
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day3\input.txt");

            var map = new Map();

            map.ParseMap(file);

            map.RunMapTraverse();

            Console.WriteLine(map.NumberOfTreesHit);
        
        }

        public void Part2()
        {
            var rulesList = new List<Tuple<int, int>>();
            rulesList.Add(new Tuple<int, int>(1, 1));
            rulesList.Add(new Tuple<int, int>(3, 1));
            rulesList.Add(new Tuple<int, int>(5, 1));
            rulesList.Add(new Tuple<int, int>(7, 1));
            rulesList.Add(new Tuple<int, int>(1, 2));

            var results = new List<int>();

            foreach(var rule in rulesList)
            {
                var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day3\input.txt");

                var map = new Map();

                map.ParseMap(file);

                map.RunMapTraverse(rule.Item1, rule.Item2);

                Console.WriteLine(map.NumberOfTreesHit);

                results.Add(map.NumberOfTreesHit);
            }

            Console.WriteLine(results[0] * results[1] * results[2] * results[3] * results[4]);

        }
    }
}
