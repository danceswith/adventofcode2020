using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2020.Days
{
    class Day1
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\input.txt");

            foreach(var inputLine1 in file)
            {
                var int1 = int.Parse(inputLine1);

                foreach(var inputLine2 in file)
                {
                    var int2 = int.Parse(inputLine2);

                    if (int1 + int2 == 2020)
                    {
                        Console.WriteLine($"{int1 * int2}");
                    }
                }
            }
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\input.txt");

            foreach (var inputLine1 in file)
            {
                var int1 = int.Parse(inputLine1);

                foreach (var inputLine2 in file)
                {
                    var int2 = int.Parse(inputLine2);

                    foreach(var inputLine3 in file)
                    {
                        var int3 = int.Parse(inputLine3);

                        if (int1 + int2 + int3 == 2020)
                        {
                            Console.WriteLine($"{int1 * int2 * int3}");
                        }
                    }
                    
                }
            }
        }
    }
}
