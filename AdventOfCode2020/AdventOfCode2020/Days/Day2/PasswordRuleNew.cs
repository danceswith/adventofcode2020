using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day2
{
    public class PasswordRuleNew
    {
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public string RequiredCharacter { get; set; }
        public string Password { get; set; }
        public int IsValidCount { get; set; }
        public bool IsValid { get; set; }

        public void RunPasswordRule()
        {
            var passwordArray = Password.ToCharArray();

            if (passwordArray[Position1 - 1].ToString() == RequiredCharacter)
            {
                IsValidCount++;
            }

            if (passwordArray[Position2 - 1].ToString() == RequiredCharacter)
            {
                IsValidCount++;
            }

            if (IsValidCount == 1)
            {
                IsValid = true;
            }
        }
    }
}
