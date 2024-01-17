// See https://aka.ms/new-console-template for more information
using FizzBuzzCore;

var fizzBuzzCalculator = new FizzBuzzCalculator();
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzzCalculator.EvaluateNumber(i));
}
