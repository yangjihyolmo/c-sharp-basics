using System;

namespace OperatorsBasics
{
    public class Operators
    {
        public void OperatorsExample()
        {
            //arithemetic operators
            int x = 10;
            int y = 20;
            Console.WriteLine("The sum of number is " + (x + y));

            //assignment operators
            int x = 10;
            x += 5;
            Console.WriteLine(x);

            //comparsion operators
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y);

        }
    }
}