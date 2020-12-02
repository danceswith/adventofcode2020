using AdventOfCode2020.Days;
using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            switch(input)
            {
                case "1":

                    var day1 = new Day1();

                    day1.Part1();
                    day1.Part2();

                    break;
                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }
    }
}
