using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day8
{
    public class Computer
    {
        public List<string> Instructions = new List<string>();

        public int Accumulator = 0;

        public int CurrentInstructionIndex = 0;

        public Computer(string[] instructions)
        {
            Instructions = instructions.ToList();
        }

        public int RunComputer()
        {
            var executedInstructions = new List<int>();

            while(true)
            {
                if (CurrentInstructionIndex == Instructions.Count)
                {
                    Console.WriteLine($"Index: {CurrentInstructionIndex}. Accumulator: {Accumulator}");
                    return 0;
                }

                var instruction = Instructions[CurrentInstructionIndex];

                if (executedInstructions.Contains(CurrentInstructionIndex))
                {
                    Console.WriteLine($"Duplicate Instruction, Index: {CurrentInstructionIndex}. Accumulator: {Accumulator}");
                    return 1;
                }
                else
                {
                    executedInstructions.Add(CurrentInstructionIndex);
                }

                var opCode = instruction.Substring(0, 3);
                var opCodeInput = instruction.Substring(3).Trim();

                switch(opCode)
                {
                    case "acc":
                        acc(opCodeInput);
                        CurrentInstructionIndex += 1;
                        break;
                    case "jmp":
                        jmp(opCodeInput);
                        break;
                    case "nop":
                        nop(opCodeInput);
                        CurrentInstructionIndex += 1;
                        break;
                }
            }
        }

        private void acc(string signedInteger)
        {
            var sign = signedInteger.Substring(0, 1);
            var integer = int.Parse(signedInteger.Substring(1));

            if (sign == "-")
            {
                integer = integer * -1;
            }

            Accumulator += integer;
        }

        private void jmp(string signedInteger)
        {
            var sign = signedInteger.Substring(0, 1);
            var integer = int.Parse(signedInteger.Substring(1));

            if (sign == "-")
            {
                integer = integer * -1;
            }

            CurrentInstructionIndex += integer;
        }

        private void nop(string signedInteger)
        {

        }
    }
}
