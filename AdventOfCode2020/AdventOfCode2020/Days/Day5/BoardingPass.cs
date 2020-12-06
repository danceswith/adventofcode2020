using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Days.Day5
{
    public class BoardingPass
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int SeatID { get; set; }

       public BoardingPass(string line)
        {
            var regexMatch = Regex.Match(line, @"(?'row'[BF]{7})(?'column'[RL]{3})");

            if (!regexMatch.Success)
            {
                throw new Exception("wtf");
            }

            var rowCode = regexMatch.Groups["row"].Value;
            var columnCode = regexMatch.Groups["column"].Value;

            var rows = Enumerable.Range(0, 128).ToArray();
            var columns = Enumerable.Range(0, 8).ToArray();

            var rowCodeSplit = rowCode.ToCharArray();

            foreach (var rowCodeChar in rowCodeSplit)
            {
                switch(rowCodeChar)
                {
                    case 'F':
                        rows = rows.Take(rows.Length / 2).ToArray();
                        break;
                    case 'B':
                        rows = rows.Skip(rows.Length / 2).ToArray();
                        break;
                }

                if (rows.Length == 1)
                {
                    Row = rows[0];

                    break;
                }
            }

            var columnCodeSplit = columnCode.ToCharArray();

            foreach(var columnCodeChar in columnCodeSplit)
            {
                switch(columnCodeChar)
                {
                    case 'R':
                        columns = columns.Skip(columns.Length / 2).ToArray();
                        break;
                    case 'L':
                        columns = columns.Take(columns.Length / 2).ToArray();
                        break;
                }

                if (columns.Length == 1)
                {
                    Column = columns[0];
                    break;
                }
            }

            SeatID = (Row * 8) + Column;
        }
    }
}
