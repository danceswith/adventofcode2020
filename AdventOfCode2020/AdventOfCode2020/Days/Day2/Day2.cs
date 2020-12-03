using AdventOfCode2020.Days.Day2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day2
{
    public class Day2
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day2\input.txt");


            var passwordRules = new List<PasswordRule>();

            foreach(var line in file)
            {
                var passwordRule = new Days.Day2.PasswordRule();

                var counts = line.Split(" ").First();

                passwordRule.MinimumCount = int.Parse(counts.Split("-").First());
                passwordRule.MaximumCount = int.Parse(counts.Split("-").Last());

                var lineSplit = line.Split(":");

                passwordRule.RequiredCharacter = lineSplit[0].Substring(lineSplit[0].Length - 1, 1);
                passwordRule.Password = lineSplit[1].Trim();

                passwordRule.RunPasswordRule();

                passwordRules.Add(passwordRule);
            }

            Console.WriteLine(passwordRules.Count(pr => pr.IsValid));
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day2\input.txt");

            var passwordRules = new List<PasswordRuleNew>();

            foreach (var line in file)
            {
                var passwordRule = new Days.Day2.PasswordRuleNew();

                var counts = line.Split(" ").First();

                passwordRule.Position1 = int.Parse(counts.Split("-").First());
                passwordRule.Position2 = int.Parse(counts.Split("-").Last());

                var lineSplit = line.Split(":");

                passwordRule.RequiredCharacter = lineSplit[0].Substring(lineSplit[0].Length - 1, 1);
                passwordRule.Password = lineSplit[1].Trim();

                passwordRule.RunPasswordRule();

                passwordRules.Add(passwordRule);
            }

            Console.WriteLine(passwordRules.Count(pr => pr.IsValid));
        }
    }
}
