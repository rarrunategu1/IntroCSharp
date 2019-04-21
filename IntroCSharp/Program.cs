using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{   
    class Program
    {
        public static void arrays()
        {
            Console.WriteLine("arrays Method: ");
            int[] numbers = new int[] { 4, 6, 34, 5, 7, 3};

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf() finds position of element of array
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Index of 6: " +index);

            //Clear() parameters are array, where you'd like to start clearing and how many to clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear() ");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
                //you'll see Clear() sets the int value to zero
            }

            //Copy()
            Console.WriteLine("Effect of Copy() " );
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);

            foreach (int n in anotherArray)
            {
                Console.WriteLine(n);
            }

            //Sort() - sort from lowest to highest
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort() ");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse() - returns the numbers in the array in reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reversed() ");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void lists()
        {
            Console.WriteLine("lists Method: ");
            List<int>numbers = new List<int>() {1, 2, 3, 4};
            Console.WriteLine("Using .Add() and .AddRange() to a list initialized with 1,2,3,4.  ");
            numbers.Add(2);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("Using IndexOf() and LastIndexOf() ");
            Console.WriteLine("Index of 2: " +numbers.IndexOf(2));
            Console.WriteLine("Last Index of 2: " + numbers.LastIndexOf(2));

            Console.WriteLine();
            Console.WriteLine("Using Count property ");
            Console.WriteLine("Count: " +numbers.Count);

            Console.WriteLine();
            Console.WriteLine("Using Remove Method ");
            //below will only remove first instance of 2
            //numbers.Remove(2);

            //foreach (var n in numbers)
            //{
                //if (n == 2)
                //{
                   // //cannot modify our collection with a foreach loop with numbers.Remove(n);
                //}
            //}

            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] == 2)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("Using .Clear() clears all the numbers from the list ");
            numbers.Clear();

            Console.WriteLine("Count: " + numbers.Count);
        }

        public static void facebookLikes()
        {
            List<string>facebookFriends = new List<string>();
                   
            while (true)
            {
                Console.WriteLine("Please enter a name to store in your friends list and press enter.  Press enter without entering a name to escape: ");
                string userInput = Console.ReadLine();
                
                if (userInput != "")
                {
                    facebookFriends.Add(userInput);
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch(facebookFriends.Count)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine(facebookFriends[0] + " likes your post.");
                    break;
                case 2:
                    Console.WriteLine(facebookFriends[0] + " and " + facebookFriends[1] + " like your post.");
                    break;
                default:
                    Console.WriteLine(facebookFriends[0] + ", " + facebookFriends[1] + " and " + (facebookFriends.Count - 2) + " other friends like your post.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            arrays();
            Console.WriteLine();

            lists();
            Console.WriteLine();

            facebookLikes();
            Console.WriteLine();


            
        }
    }
}
