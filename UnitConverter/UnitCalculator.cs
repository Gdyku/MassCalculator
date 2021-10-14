using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    public class UnitCalculator
    {
        public decimal Calculate(decimal weight, int sourceunit, int outputunit)
        {
            IConverter converter = null;
            switch(sourceunit)
            {
                case 1:
                    converter = new GramConverter();
                    break;
                case 2:
                    converter = new MgConverter();
                    break;
                case 3:
                    converter = new LbsConverter();
                    break;
                case 4:
                    converter = new OzConverter();
                    break;
            }

            var convertedValue = converter.Convert(weight, outputunit);
            return convertedValue;
        }
    }
}
