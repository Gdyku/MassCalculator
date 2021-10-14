using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    class OzConverter : IConverter
    {
        public decimal Convert(decimal weight, int outputUnit)
        {
            decimal result;
            switch (outputUnit)
            {
                case 1:
                    result = ConvertToGrams(weight);
                    return result;
                case 2:
                    result = ConvertToMiligrams(weight);
                    return result;
                case 3:
                    result = ConvertToPounds(weight);
                    return result;
                case 4:
                    result = weight;
                    return result;
                default:
                    return 0;
            }
        }

        private decimal ConvertToGrams(decimal weight)
        {
            decimal grams = weight * (decimal)28.349523125;
            return grams;
        }

        private decimal ConvertToPounds(decimal weight)
        {
            decimal pounds = weight * (decimal)0.0625;
            return pounds;
        }

        private decimal ConvertToMiligrams(decimal weight)
        {
            decimal miligrams = weight * (decimal)28349.523125;
            return miligrams;
        }
    }
}
