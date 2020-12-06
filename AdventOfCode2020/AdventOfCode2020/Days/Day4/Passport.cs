using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Days.Day4
{
    public class Passport
    {
        public int? BirthYear { get; set; }
        public int? IssueYear { get; set; }
        public int? ExpirationYear { get; set; }
        public int? Height { get; set; }
        public string HairColour { get; set; }
        public string EyeColour { get; set; }
        public string PassportID { get; set; }
        public string CountryID { get; set; }
        public bool IsValid { get; set; }

        public Passport(List<string> passportLines)
        {
            foreach(var line in passportLines)
            {
                var lineSplit = line.Split(" ");

                foreach(var lineSplitElement in lineSplit)
                {
                    ParsePassportElement(lineSplitElement);
                }
            }

            IsPassportValid();
        }

        private void ParsePassportElement(string passportElement)
        {
            var passportElementSplit = passportElement.Split(":");

            switch(passportElementSplit[0])
            {
                case "byr":
                    if (int.TryParse(passportElementSplit[1], out var birthYear) && passportElementSplit[1].Length == 4)
                    {
                        if (birthYear >= 1920 && birthYear <= 2002)
                        {
                            BirthYear = birthYear;
                        }
                    }
                    break;
                case "iyr":
                    if (int.TryParse(passportElementSplit[1], out var issueYear) && passportElementSplit[1].Length == 4)
                    {
                        if (issueYear >= 2010 && issueYear <= 2020)
                        {
                            IssueYear = issueYear;
                        }
                    }
                    break;
                case "eyr":
                    if (int.TryParse(passportElementSplit[1], out var expirationYear) && passportElementSplit[1].Length == 4)
                    {
                        if (expirationYear >= 2020 && expirationYear <= 2030)
                        {
                            ExpirationYear = expirationYear;
                        }
                    }
                    break;
                case "hgt":
                    var heightType = passportElementSplit[1].Substring(passportElementSplit[1].Length - 2, 2);
                    var height = passportElementSplit[1].Substring(0, passportElementSplit[1].Length - 2);

                    if (int.TryParse(height, out var heightInt))
                    {
                        if (heightType.ToUpper() == "CM")
                        {
                            if (heightInt >= 150 && heightInt <= 193)
                            {
                                Height = heightInt;
                            }
                        }
                        else if (heightType.ToUpper() == "IN")
                        {
                            if (heightInt >= 59 && heightInt <= 76)
                            {
                                Height = heightInt;
                            }
                        }
                    }
                    break;
                case "hcl":
                    var regexMatch = Regex.Match(passportElementSplit[1], @"#(?'number'[\dabcdef]{6})");

                    if (regexMatch.Success)
                    {
                        if (passportElementSplit[1].Length == 7)
                        {
                            HairColour = regexMatch.Groups["number"].Value;
                        }
                    }
                    
                    break;
                case "ecl":
                    switch(passportElementSplit[1])
                    {
                        case "amb":
                        case "blu":
                        case "brn":
                        case "gry":
                        case "grn":
                        case "hzl":
                        case "oth":
                            EyeColour = passportElementSplit[1];
                            break;
                    }
                    break;
                case "pid":
                    var regexMatch2 = Regex.Match(passportElementSplit[1], @"(?'number'\d{9})");

                    if (regexMatch2.Success)
                    {
                        if (passportElementSplit[1].Length == 9)
                        {
                            PassportID = regexMatch2.Groups["number"].Value;
                        }
                    }
                    
                    break;
                case "cid":
                    CountryID = passportElementSplit[1];
                    break;
            }
        }

        public void IsPassportValid()
        {
            IsValid = BirthYear.HasValue
                && IssueYear.HasValue
                && ExpirationYear.HasValue
                && Height.HasValue
                && !string.IsNullOrWhiteSpace(HairColour)
                && !string.IsNullOrWhiteSpace(EyeColour)
                && !string.IsNullOrWhiteSpace(PassportID);
        }
    }
}
