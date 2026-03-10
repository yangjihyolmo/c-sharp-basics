using System;
using CsharpBasics.CastingBasics;
using VariableBasics;
using UserInputBasics;
using OperatorsBasics;
using MathsBasics;
using StringsBasics;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Casting casting = new();
            casting.CastingExample();

            Variable v = new();
            v.VariableExample();

            UserInput user = new();
            user.UserInputExample();

            Operators op = new();
            op.OperatorsExample();

            Maths m = new();
            m.MathsExample();

            Strings str = new();
            str.StringExample();

            Console.WriteLine("\n Hello World!");
            Console.WriteLine("I'm learning c#!");
            Console.WriteLine(3 + 3);
            Console.Write("hello ");
            Console.Write("It will print in same line");
        }
    }
}
