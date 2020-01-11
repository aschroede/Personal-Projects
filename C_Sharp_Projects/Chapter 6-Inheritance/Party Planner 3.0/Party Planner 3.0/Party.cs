﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_3._0
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() + (NumberOfPeople * CostOfFoodPerPerson);
                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costofDecorations;
            if (FancyDecorations)
                costofDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costofDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costofDecorations;
        }
    }
}