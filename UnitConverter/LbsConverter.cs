using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    class LbsConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch(outputUnit)
            {
                case 1:
                    result = ConvertToGrams(weight);
                    return result;
                case 2:
                    result =  ConvertToMiligrams(weight);
                    return result;
                case 3:
                    result = weight;
                    return result;
                case 4:
                    result = ConvertToOunces(weight);
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertToGrams(decimal weight)
        {
            decimal grams = weight * (decimal)453.59237;
            return grams;
        }

        private decimal ConvertToOunces(decimal weight)
        {
            decimal ounces = weight * 16;
            return ounces;
        }

        private decimal ConvertToMiligrams(decimal weight)
        {
            decimal miligrams = weight * (decimal)453592.37;
            return miligrams;
        }
    }
}
