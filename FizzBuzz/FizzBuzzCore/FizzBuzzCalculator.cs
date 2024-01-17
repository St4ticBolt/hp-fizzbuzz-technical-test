using System;

namespace FizzBuzzCore
{
    public class FizzBuzzCalculator
    {
        public string EvaluateNumber(int number)
        {
            bool fizz = number % 3 == 0;
            bool buzz = number % 5 == 0;

            if (fizz && buzz)
                return Constants.FIZZ_BUZZ;
            if (fizz)
                return Constants.FIZZ;
            if (buzz)
                return Constants.BUZZ;

            return number.ToString();
        }
    }

}

