﻿using AdventOfCode2020.Days;
using AdventOfCode2020.Days.Day1;
using AdventOfCode2020.Days.Day2;
using AdventOfCode2020.Days.Day3;
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
                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }
    }
}
