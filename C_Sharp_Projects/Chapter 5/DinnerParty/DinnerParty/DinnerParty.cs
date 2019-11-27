using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public const int CostOfFoodPerPerson = 25;
        private bool ApplyDiscount;
        public decimal Cost
        {
            get
            {
                if (HealthyOption)
                {
                    return 0.95M * (CalCulateCostOfDecarations() + NumberOfPeople * (CalculateCostOfBeveragesPerPerson(HealthyOption) + CostOfFoodPerPerson));
                }
                else
                {
                    return (CalCulateCostOfDecarations() + NumberOfPeople * (CalculateCostOfBeveragesPerPerson(HealthyOption) + CostOfFoodPerPerson));
                }
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfBeveragesPerPerson(bool healthyOption)
        {
            if (healthyOption)
            {
                return 5;
            }

            else
            {
                return 20;
            }
        }

        public decimal CalCulateCostOfDecarations()
        {
            if (!FancyDecorations)
            {
                return 7.50M * NumberOfPeople + 30;
            }
            else
            {
                return 15M * NumberOfPeople + 50;
            }
        }
    }
}
