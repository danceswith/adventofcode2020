using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day5
{
    public class Day5
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day5\input.txt");

            var boardingPasses = new List<BoardingPass>();

            foreach(var line in file)
            {
                var boardingPass = new BoardingPass(line);

                Console.WriteLine($"Row: {boardingPass.Row}, Column: {boardingPass.Column}, SeatID: {boardingPass.SeatID}");

                boardingPasses.Add(boardingPass);
            }

            Console.WriteLine($"Max SeatID: {boardingPasses.Max(bp => bp.SeatID)}");

        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day5\input.txt");

            var boardingPasses = new List<BoardingPass>();

            foreach (var line in file)
            {
                var boardingPass = new BoardingPass(line);

                Console.WriteLine($"Row: {boardingPass.Row}, Column: {boardingPass.Column}, SeatID: {boardingPass.SeatID}");

                boardingPasses.Add(boardingPass);
            }

            var missingSeats = new List<int>();

            for (var seatid = 0; seatid < 928; seatid++)
            {
                if (!boardingPasses.Any(bp => bp.SeatID == seatid))
                {
                    if (boardingPasses.Any(bp => bp.SeatID == seatid - 1) && boardingPasses.Any(bp => bp.SeatID == seatid + 1))
                    {
                        missingSeats.Add(seatid);
                    }
                }
            }

            Console.WriteLine($"My seat: {missingSeats.First()}");
        }
    }
}
