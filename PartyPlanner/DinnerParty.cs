using System;
using System.Collections.Generic;
using System.Text;

namespace PartyPlanner
{
    class DinnerParty
    {

        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfDecorations = 0;
        public decimal CostOfBeveragesPerPerson;

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfDecorations) * NumberOfPeople); 
            
            //plus 5% discount
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }

        }
        
    }
}
