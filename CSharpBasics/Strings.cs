using System;

namespace StringsBasics
{
    public class Strings
    {
        public void StringExample()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            //assess string
            Console.WriteLine(txt[0]);
            Console.WriteLine(txt.IndexOf("e")); //to find index position

            //substring
            string personName = "Ram Kumar";
            int location = personName.IndexOf("K");
            string personLastName = personName.Substring(location);
            Console.WriteLine(personLastName);

            //concat
            string firstName = "Yangji ";
            string lastName = "Lama";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            //interpolation
            string name_ = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name_);
        }
    }
}