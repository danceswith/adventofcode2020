using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day9
{
    public class Day9
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day9\input.txt");

            var position = 5;
            var preamble = 25;

            while(true)
            {
                var preambleArray = file.Skip(position - preamble).Take(preamble).ToArray();

                var numberToCheck = file[position];

                var isCorrect = false;

                foreach(var number in preambleArray)
                {
                    foreach(var number2 in preambleArray)
                    {
                        if (long.Parse(number) + long.Parse(number2) == long.Parse(numberToCheck))
                        {
                            isCorrect = true;
                        }
                    }
                }

                if (!isCorrect)
                {
                    Console.WriteLine(numberToCheck);

                    return;
                }

                position++;
            }
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day9\input.txt");

            var invalidNumber = 1492208709;

            var position = 0;

            while(true)
            {
                var numbers = new List<int>();

                numbers.Add(int.Parse(file[position]));

                var pos = position + 1;

                while(numbers.Sum() != invalidNumber && numbers.Sum() < invalidNumber)
                {
                    numbers.Add(int.Parse(file[pos]));

                    pos++;
                }

                if (numbers.Sum() == invalidNumber)
                {
                    var answer = numbers.Min() + numbers.Max();

                    Console.WriteLine(answer);

                    return;
                }

                position++;

            }

        }
    }
}
