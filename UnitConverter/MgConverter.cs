using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    class MgConverter : IConverter
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
                    result = weight;
                    return result;
                case 3:
                    result = ConvertToPounds(weight);
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
            decimal grams = weight * (decimal)0.001;
            return grams;
        }

        private decimal ConvertToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0000022046;
            return pounds;
        }

        private decimal ConvertToOunces(decimal weight)
        {
            decimal ounces = weight * (decimal)0.000035274;
            return ounces;
        }
    }
}
