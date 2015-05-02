using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {

        public double maxWeight;
        public int noOfItem;
        public double weightPerItem;
        public double totalWeight;
        public double currentWeight = 0.0;
        public double remainingWeight=0.0;

       
        public double TotalWeight()
        {
            totalWeight = noOfItem*weightPerItem;

            return totalWeight;
        }

        public double GetCurrentWeight()
        {
            currentWeight = currentWeight+totalWeight;
            return currentWeight;
        }


        public double GetRemainingWeight()
        {
            remainingWeight = maxWeight - currentWeight;

            return remainingWeight;

        }
    }
}
