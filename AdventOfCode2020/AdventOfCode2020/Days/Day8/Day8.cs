using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2020.Days.Day8
{
    public class Day8
    {
        public void Part1()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day8\input.txt");

            var computer = new Computer(file);

            computer.RunComputer();
        }

        public void Part2()
        {
            var file = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day8\input.txt");

            var counter = 0;

            foreach(var line in file)
            {
                var newFile = File.ReadAllLines(@"D:\Projects\adventofcode2020\AdventOfCode2020\AdventOfCode2020\Days\Day8\input.txt");

                var opCode = line.Substring(0, 3);

                switch(opCode)
                {
                    case "jmp":

                        newFile[counter] = newFile[counter].Replace("jmp", "nop");

                        var jmpcmptr = new Computer(newFile);

                        var jmpoutput = jmpcmptr.RunComputer();

                        if (jmpoutput == 0)
                        {
                            return;
                        }

                        break;
                    case "nop":

                        newFile[counter] = newFile[counter].Replace("jmp", "nop");

                        var nopcmptr = new Computer(newFile);

                        var nopoutput = nopcmptr.RunComputer();

                        if (nopoutput == 0)
                        {
                            return;
                        }
                        break;
                }

                counter++;
            }
        }
    }
}
