using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Days.Day2
{
    public class PasswordRule
    {
        public int MinimumCount { get; set; }
        public int MaximumCount { get; set; }
        public string RequiredCharacter { get; set; }
        public string Password { get; set; }
        public bool IsValid { get; set; }

        public void RunPasswordRule()
        {
            var passwordArray = this.Password.ToCharArray().ToList();

            if (passwordArray.Count(p => p.ToString() == RequiredCharacter) >= MinimumCount && passwordArray.Count(p => p.ToString() == RequiredCharacter) <= MaximumCount)
            {
                IsValid = true;
            }
        }
    }
}
