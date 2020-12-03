using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Days.Day3
{
    public class Map
    {
        public char[,] MapArray;
        public int NumberOfTreesHit = 0;

        public Map()
        {
            MapArray = new char[1000, 1000];
        }

        public void ParseMap(string[] mapInput)
        {
            var lineCount = 0;

            foreach (var inputLine in mapInput)
            {
                var inputLineCharArray = inputLine.ToCharArray();

                var lineArrayCount = 0;
                foreach (var inputLineChar in inputLineCharArray)
                {
                    MapArray[lineCount, lineArrayCount] = inputLineChar;

                    lineArrayCount++;
                }

                lineCount++;
            }
        }

        public void RunMapTraverse(int colPosChange = 3, int rowPosChange = 1)
        {
            int rowPos = 0;
            int colPos = 0;

            while(true)
            {
                var currentPosChar = MapArray[rowPos, colPos];

                if (currentPosChar == '\0')
                {
                    return;
                }

                if (currentPosChar == '#')
                {
                    NumberOfTreesHit++;
                }

                rowPos += rowPosChange;

                if (colPos + colPosChange > 30)
                {
                    colPos = (colPos + colPosChange) - 31;
                }
                else
                {
                    colPos += colPosChange;
                }
            }
        }
    }
}
