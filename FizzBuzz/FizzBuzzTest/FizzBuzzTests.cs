using FizzBuzzCore;
using System.Runtime.CompilerServices;

namespace FizzBuzzTest
{
    public class Tests
    {
        private int _displayFizz = 18;
        private int _displayBuzz = 10;
        private int _displayFizzBuzz = 30;
        private int _displayNumber = 7;

        private FizzBuzzCalculator fizzBuzzCalculation;

        [SetUp]
        public void Setup()
        {
            fizzBuzzCalculation = new FizzBuzzCalculator();
        }

        /// <summary>
        /// "Fizz" will be returned when a number is divisible by 3
        /// </summary>
        [Test]
        public void CorrectlyReturnsFizz()
        {
            var fizz = fizzBuzzCalculation.EvaluateNumber(_displayFizz);
            Assert.AreEqual(Constants.FIZZ, fizz);
        }
        /// <summary>
        /// "Buzz" will be returned when a number is divisible by 5
        /// </summary>
        /// 
        [Test]
        public void CorrectlyReturnsBuzz()
        {
            var buzz = fizzBuzzCalculation.EvaluateNumber(_displayBuzz);
            Assert.AreEqual(Constants.BUZZ, buzz);
        }
        /// <summary>
        /// "Fizz" will be returned when a number is divisible by 3 and 5 
        /// </summary>
        [Test]
        public void CorrectlyReturnsFizzBuzz()
        {
            var fizzBuzz = fizzBuzzCalculation.EvaluateNumber(_displayFizzBuzz);
            Assert.AreEqual(Constants.FIZZ_BUZZ, fizzBuzz);
        }

        /// <summary>
        /// When the value is not divisible by 3 or 5 then it will return the number in string form. 
        /// </summary>
        [Test]
        public void CorrectlyReturnsNumber()
        {
            var number = fizzBuzzCalculation.EvaluateNumber(_displayNumber);
            Assert.AreEqual(_displayNumber.ToString(), number);
        }


    }
}