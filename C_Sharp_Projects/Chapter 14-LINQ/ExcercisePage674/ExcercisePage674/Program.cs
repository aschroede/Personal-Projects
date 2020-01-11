using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisePage674
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, decimal> values = GetPrices();

            var priceGroups =
                from pair in values
                group pair.Key by EvaluatePrice(pair.Value)
                into priceGroup
                orderby priceGroup.Key descending
                select priceGroup;

            foreach (var group in priceGroups)
            {
                Console.Write("I found {0} {1} comics: issues ", group.Count(), group.Key);
                foreach (var issueNumber in group)
                {
                    Console.Write(issueNumber.ToString() + " ");
                }
                Console.WriteLine(); ;
            }
            Console.ReadKey();
        }

        static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M) return PriceRange.Cheap;
            else if (price < 1000M) return PriceRange.Midrange;
            else return PriceRange.Expensive;
        }

        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                { 6, 3600M }, {19, 500M}, {36, 650M}, {57, 13525M},
                {68, 250M }, {74, 74M}, {83, 25.7M}, {97, 35.25M},
            };
        }
    }

    enum PriceRange { Cheap, Midrange, Expensive}

}