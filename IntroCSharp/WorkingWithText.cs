using System;

namespace IntroCSharp
{
    class WorkingWithText
    {
        public void stringFun()
        {
            string fullName = "Bill Taylor ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim and ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            //Split fullName into first and last name
            int index = fullName.IndexOf(" ");
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            
            Console.WriteLine("First Name: " +firstName);
            Console.WriteLine("Last Name: " + lastName);

            //easier method to split the fullname
            string [] names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);

            Console.WriteLine();

            //Replace will return new strings since strings are immutable
            Console.WriteLine(fullName.Replace("Bill", "Billy"));
            
            Console.WriteLine(fullName.Replace('i', 'I'));

            //validate a credit card
            //null and "" will return invalid but " " will not.
            //" " will need to have trim method.  " ".Trim() - better to just use IsNullOrWhiteSpace version
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            //Convert string to number
            string ageInput = "25";
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine(age);

            //Convert float to string formatted as currency
            float price = 2.34f;
            //"C0 will round it to 2 dollars
            string currency = price.ToString("C");
            Console.WriteLine(currency);




        }
    }
}