using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day4
{
    public class Day4
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day4\input.txt");

            var passportLines = new List<string>();
            var passports = new List<Passport>();

            foreach(var line in file)
            {
                if (line.Length == 0)
                {
                    passports.Add(new Passport(passportLines));

                    passportLines = new List<string>();

                    continue;
                }

                passportLines.Add(line);
            }

            passports.Add(new Passport(passportLines));

            Console.WriteLine(passports.Count(p => p.IsValid));
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day4\input.txt");


        }
    }
}
