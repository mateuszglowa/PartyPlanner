using System;
using System.Collections.Generic;
using System.Text;

namespace PartyPlanner
{
    class DinnerParty
    {


        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorations = fancyDecorations;
            this.HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            
            if (FancyDecorations)
            {
                return (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                return (NumberOfPeople * 7.50M) + 30M;
            }
             
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return  5.00M;
            }
            else
            {
                return 20.00M;
            }


        }

        public decimal Cost()
        {
            decimal totalCost = CalculateCostOfDecorations();
            totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);

            //5% discount
            if (HealthyOption)
            {
                totalCost *= .95M;
            }
            
                return totalCost;
            
        }

        

    }
}
