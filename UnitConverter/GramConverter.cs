using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    class GramConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch(outputUnit)
            {
                case 1:
                    result = weight;
                    return result;
                case 2:
                    result = ConvertToMiligrams(weight);
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

        private decimal ConvertToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0022046226;
            return pounds;
        }

        private decimal ConvertToOunces(decimal weight)
        {
            decimal ounces = weight * (decimal)0.0352739619;
            return ounces;
        }

        private decimal ConvertToMiligrams(decimal weight)
        {
            decimal miligrams = weight * 1000;
            return miligrams;
        }
    }
}
