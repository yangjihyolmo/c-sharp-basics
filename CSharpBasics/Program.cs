using System;
using CsharpBasics.CastingBasics;
using VariableBasics;
using UserInputBasics;
using OperatorsBasics;
using MathsBasics;
using StringsBasics;

namespace CsharpBasics
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    //inheritance
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            
            Person myObj = new Person();
            myObj.Name = "Sandhya\n";
            Console.WriteLine(myObj.Name);

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
