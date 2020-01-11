using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_3._0
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += NumberOfPeople * CalculateCostOfBeveragesPerPerson();
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5;
            }

            else
            {
                return 20;
            }
        }
    }
}
