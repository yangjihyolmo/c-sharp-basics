using System;
using CsharpBasics.CastingBasics;
using VariableBasics;
using UserInputBasics;
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

      Console.WriteLine("\n Hello World!");
      Console.WriteLine("I'm learning c#!");
      Console.WriteLine(3 + 3);
      Console.Write("hello ");
      Console.Write("It will print in same line");
    }
  }
}
