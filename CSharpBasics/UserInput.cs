using System;

namespace UserInputBasics
{
    public class UserInput
    {
        public void UserInputExample()
        {
            Console.WriteLine("Enter UserName: ");

            String UserName = Console.ReadLine();

            Console.WriteLine("UserName is " + UserName);

            Console.WriteLine("\nEnter your age:");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);

        }
    }
}