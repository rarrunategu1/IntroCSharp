using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    class Exercises
    {
        public static string consecutiveNumbersOrNot()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen (eg. 5-6-7-8-9): ");
            string input = Console.ReadLine();

            //.Select applies a method to the elements in a collection
            int[] numbers = input.Split('-').Select(int.Parse).ToArray();
            
            string areNumbersConsecutive = "";
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if ((numbers[i + 1] - numbers[i]) == 1)
                {
                    areNumbersConsecutive = "Consecutive";
                }
                else if ((numbers[i + 1] - numbers[i]) != 1)
                {
                    areNumbersConsecutive = "Not Consecutive";
                }
            }
            return areNumbersConsecutive;
        }

        public static void duplicateNumbers()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen: ");
            string input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
                      
            string[] numbers = input.Split('-');

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                { 
                    if (numbers[i] == (numbers[j]))
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                }
            }
    
        }
        public static void timeValidity()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var hourAndTime = input.Split(':');
            if (hourAndTime.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            if ((Convert.ToInt32(hourAndTime[0]) <= 23 && Convert.ToInt32(hourAndTime[0]) >= 0) && (Convert.ToInt32(hourAndTime[1]) <= 59 && Convert.ToInt32(hourAndTime[1]) >= 0))
            {
                Console.WriteLine("OK");
                return;
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
