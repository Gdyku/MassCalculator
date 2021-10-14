using System;
using UnitConverter;

namespace MassCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
            Start:
                Console.WriteLine("Which kind of weight you want to calculate? Please type a number for an answer");
                Console.WriteLine("1. Grams\n2. Miligrams\n3. Pounds\n4. Ounces");
                int unitFrom = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you want to calculate?");
                decimal weight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("In which units do you want to get the answer?");
                Console.WriteLine("1. Grams\n2. Miligrams\n3. Pounds\n4. Ounces");
                int unitTo = Convert.ToInt32(Console.ReadLine());

                var calculator = new UnitCalculator();
                var answer = calculator.Calculate(weight, unitFrom, unitTo);
                if(unitFrom == unitTo)
                {
                    Console.WriteLine($"You have used the same unit so you already have an answer ;)");
                }
                else
                {
                    Console.WriteLine($"The result is {answer}");
                }

            FinalQuestion:
                Console.WriteLine("Do you want to contiue work?\n Please type Y if yes or N if you want to quit");
                char sign = Convert.ToChar(Console.ReadLine().ToUpper());

                if (sign == 'Y')
                    goto Start;
                else if (sign == 'N')
                    break;
                else
                {
                    Console.WriteLine("please type correct answer");
                    goto FinalQuestion;
                }
            }
        }
    }
}
