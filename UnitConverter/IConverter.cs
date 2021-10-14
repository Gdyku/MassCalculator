using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConverter
{
    interface IConverter
    {
        decimal Convert(decimal weight, int outputUnit);
    }
}
    