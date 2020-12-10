using AdventOfCode2020.Days;
using AdventOfCode2020.Days.Day1;
using AdventOfCode2020.Days.Day2;
using AdventOfCode2020.Days.Day3;
using AdventOfCode2020.Days.Day4;
using AdventOfCode2020.Days.Day5;
using AdventOfCode2020.Days.Day6;
using AdventOfCode2020.Days.Day7;
using AdventOfCode2020.Days.Day8;
using AdventOfCode2020.Days.Day9;
using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number to run:");

            var input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    var day1 = new Day1();
                    day1.Part1();
                    day1.Part2();
                    break;
                case "2":
                    var day2 = new Day2();
                    day2.Part1();
                    day2.Part2();
                    break;
                case "3":
                    var day3 = new Day3();
                    day3.Part1();
                    day3.Part2();
                    break;
                case "4":
                    var day4 = new Day4();
                    day4.Part1();
                    day4.Part2();
                    break;
                case "5":
                    var day5 = new Day5();
                    day5.Part1();
                    day5.Part2();
                    break;
                case "6":
                    var day6 = new Day6();
                    day6.Part1();
                    day6.Part2();
                    break;
                case "7":
                    var day7 = new Day7();
                    day7.Part1();
                    day7.Part2();
                    break;
                case "8":
                    var day8 = new Day8();
                    day8.Part1();
                    day8.Part2();
                    break;
                case "9":
                    var day9 = new Day9();
                    day9.Part1();
                    day9.Part2();
                    break;
                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }
    }
}
