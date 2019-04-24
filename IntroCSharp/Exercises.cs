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
            
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if ((numbers[i+1] - numbers[i]) == 1)
                {
                    areNumbersConsecutive = "Consecutive";
                }
                else if ((numbers[i+1] - numbers[i]) != 1)
                {
                    areNumbersConsecutive = "Not Consecutive";
                }
            }
            return areNumbersConsecutive;
        }
    }
}
