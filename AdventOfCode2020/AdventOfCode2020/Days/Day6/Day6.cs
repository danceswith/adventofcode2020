using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day6
{
    public class Day6
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day6\input.txt");

            var groupsLines = new List<List<string>>();
            var groupLines = new List<string>();

            foreach(var line in file)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    groupsLines.Add(groupLines);
                    groupLines = new List<string>();
                    continue;
                }

                groupLines.Add(line);
            }

            groupsLines.Add(groupLines);

            var distinctGroupsLines = new List<List<char>>();

            foreach(var lines in groupsLines)
            {
                var distinctAnswers = new List<char>();

                foreach(var line in lines)
                {
                    var answers = line.ToCharArray();

                    foreach(var answer in answers)
                    {
                        if (!distinctAnswers.Contains(answer))
                        {
                            distinctAnswers.Add(answer);
                        }
                    }
                }

                distinctGroupsLines.Add(distinctAnswers);
            }

            Console.WriteLine($"Sum of distinct group answers: {distinctGroupsLines.Sum(g => g.Count())}");
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day6\input.txt");

            var groupsLines = new List<List<List<char>>>();
            var groupLines = new List<List<char>>();

            foreach (var line in file)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    groupsLines.Add(groupLines);
                    groupLines = new List<List<char>>();
                    continue;
                }

                var lineArray = line.ToCharArray().ToList();
                groupLines.Add(lineArray);
            }

            groupsLines.Add(groupLines);

            var distinctGroupsLines = new List<List<char>>();

            foreach (var lines in groupsLines)
            {
                var distinctAnswers = new List<char>();

                foreach (var line in lines)
                {
                    foreach (var answer in line)
                    {
                        if (lines.All(l => l.Contains(answer)))
                        {
                            if (!distinctAnswers.Contains(answer))
                            {
                                distinctAnswers.Add(answer);
                            }
                        }
                    }
                }

                distinctGroupsLines.Add(distinctAnswers);
            }

            Console.WriteLine($"Sum of answers answered yes by a while group: {distinctGroupsLines.Sum(g => g.Count())}");
        }
    }
}
