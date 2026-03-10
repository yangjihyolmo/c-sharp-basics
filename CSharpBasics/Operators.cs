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
            Console.WriteLine("\n The sum of number is " + (x + y));

            //assignment operators
            int  z = 10;
            z += 5;
            Console.WriteLine(z);

            //comparsion operators
            int a = 5;
            int b = 3;
            Console.WriteLine(a > b);

            //Logical operators
            x = 10;
            Console.WriteLine(x > 3 && x < 10);

        }
    }
}