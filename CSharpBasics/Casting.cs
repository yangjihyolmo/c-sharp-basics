using System;

namespace CsharpBasics.CastingBasics
{
    public class Casting
    {
        public void CastingExample()
        {
            int myInt = 9;
            double myDouble = myInt;//implicit type casting
            Console.Write(myDouble);

            double num = 9.05;
            int number = (int)num; //explicit casting
            Console.WriteLine(number);

            //type conversion method
            myInt = 15;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));

        }
    }
}
