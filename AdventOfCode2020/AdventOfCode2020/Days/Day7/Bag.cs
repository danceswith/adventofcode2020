using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Days.Day7
{
    public class Bag
    {
        public string BagType { get; set; }
        public List<Bag> InnerBags { get; set; }
        public bool IsInnerBag { get; set; }
        public int Quantity { get; set; }


        public Bag(string ruleString)
        {
            InnerBags = new List<Bag>();

            var ruleSplit = ruleString.Split("bags contain");

            BagType = ruleSplit[0].Trim();

            var containsSplit = ruleSplit[1].Split(',');

            if (ruleString.Contains("no other bags"))
            {
                return;
            }

            foreach (var innerBagRule in containsSplit)
            {
                var trimmedInnerBagRule = innerBagRule.Trim();

                var quantity = trimmedInnerBagRule.Trim().Substring(0, 1);

                var innerBagType = trimmedInnerBagRule.Substring(1, trimmedInnerBagRule.Length - 1);

                innerBagType = innerBagType.Replace(".", "").Replace("bags", "").Replace("bag", "").Trim();

                InnerBags.Add(new Bag(innerBagType, int.Parse(quantity)));
            }

        }

        public Bag(string bagType, int quantity)
        {
            this.BagType = bagType;
            this.Quantity = quantity;
            this.InnerBags = new List<Bag>();
        }

        public void SetInnerBagObjects(List<Bag> bags)
        {
            foreach(var innerBag in InnerBags)
            {
                innerBag.InnerBags = bags.SingleOrDefault(b => b.BagType == innerBag.BagType).InnerBags;
            }
        }

        public bool CanBagContain(string bagType)
        {
            if (!InnerBags.Any())
            {
                return false;
            }

            if (this.BagType == bagType)
            {
                return false;
            }

            foreach(var innerBag in InnerBags)
            {
                if (innerBag.BagType == bagType)
                {
                    return true;
                }

                if (innerBag.CanBagContain(bagType))
                {
                    return true;
                }
            }

            return false;
        }

        public int SumContainingBags()
        {
            var sum = 0;

            foreach(var innerBag in InnerBags)
            {
                sum += innerBag.Quantity;

                sum += innerBag.SumContainingBags() * innerBag.Quantity;
            }

            return sum;
        }
    }
}
