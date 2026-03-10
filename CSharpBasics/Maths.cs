using System;

namespace MathsBasics
{
    public class Maths
    {
        public void MathsExample()
        {
            Console.WriteLine("The max number is " + Math.Max(5, 10));  //to find out max number
            Console.WriteLine("The min number is " + Math.Min(5, 10));  //to find out min number
            Console.WriteLine(Math.Sqrt(25));  //to find out square number
            Console.WriteLine(Math.Abs(-4.10));  //to find out absolute number
            Console.WriteLine(Math.Round(1.99)); //to find out nearest whole number after rounding
        }
    }
}