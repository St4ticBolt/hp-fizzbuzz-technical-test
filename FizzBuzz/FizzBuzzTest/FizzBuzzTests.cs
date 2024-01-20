using FizzBuzzCore;
using FizzBuzzCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace FizzBuzzTest
{
    public class Tests
    {
        private int _displayFizz = 18;
        private int _displayBuzz = 10;
        private int _displayFizzBuzz = 30;
        private int _displayNumber = 7;

        private IFizzBuzzCalculator fizzBuzzEvaluator;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection()
                .AddTransient<IFizzBuzzCalculator, FizzBuzzCalculator>()
                .BuildServiceProvider();

            fizzBuzzEvaluator = services.GetService<IFizzBuzzCalculator>();
        }

        /// <summary>
        /// "Fizz" will be returned when a number is divisible by 3
        /// </summary>
        [Test]
        public void CorrectlyReturnsFizz()
        {
            var fizz = fizzBuzzEvaluator.EvaluateNumber(_displayFizz);
            Assert.AreEqual(Constants.FIZZ, fizz);
        }
        /// <summary>
        /// "Buzz" will be returned when a number is divisible by 5
        /// </summary>
        /// 
        [Test]
        public void CorrectlyReturnsBuzz()
        {
            var buzz = fizzBuzzEvaluator.EvaluateNumber(_displayBuzz);
            Assert.AreEqual(Constants.BUZZ, buzz);
        }
        /// <summary>
        /// "Fizz" will be returned when a number is divisible by 3 and 5 
        /// </summary>
        [Test]
        public void CorrectlyReturnsFizzBuzz()
        {
            var fizzBuzz = fizzBuzzEvaluator.EvaluateNumber(_displayFizzBuzz);
            Assert.AreEqual(Constants.FIZZ_BUZZ, fizzBuzz);
        }

        /// <summary>
        /// When the value is not divisible by 3 or 5 then it will return the number in string form. 
        /// </summary>
        [Test]
        public void CorrectlyReturnsNumber()
        {
            var number = fizzBuzzEvaluator.EvaluateNumber(_displayNumber);
            Assert.AreEqual(_displayNumber.ToString(), number);
        }


    }
}