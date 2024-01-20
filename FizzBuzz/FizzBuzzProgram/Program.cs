// See https://aka.ms/new-console-template for more information
using FizzBuzzCore;
using FizzBuzzCore.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection()
    .AddTransient<IFizzBuzzCalculator, FizzBuzzCalculator>()
    .BuildServiceProvider();

var fizzBuzzCalculator = services.GetRequiredService<IFizzBuzzCalculator>();


for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzzCalculator.EvaluateNumber(i));
}



