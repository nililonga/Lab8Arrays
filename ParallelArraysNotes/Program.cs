using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelArraysNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {

                //make arrays
                string[] names = { "abby", "bobby", "cindy", "danny", "emmy", "freddy", "gabby", "holly", "iggy", "jimmy", "kimmy", "lindsey", "mindy", "ozzy", "pauly", "Q", "robby", "sammy", "tammy", "Ulysses" };
                double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
                string[] hometown = { "austin", "boston", "charlette", "denver", "elsewhere", "fort wayne", "grand rapids", "houston", "indianapolis", "jackson", "kansas city", "los angeles", "memphis", "new york city", "oklahoma city", "pheonix", "queens", "raleigh", "salt lake city", "tuscon", "detroit", "vancouver" };
                string[] food = { "cookie", "chips", "skittles", "shrimp", "wings", "spaghetti", "cake", "ice", "peanuts", "fish", "fries", "broccoli", "apples", "pie", "sushi", "rice", "stir fry", "smoothies", "egg roll", "burgers" };

                //choose student number
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{numbers[i]}: {names[i]}");
                }
                //ask about students
                Console.WriteLine("\n\n");
                Console.WriteLine("which student would you like to know about (1-20)?");
                string input = (Console.ReadLine());
                int index;

                //shift users input so it's 0-4 and not 1-5
                int.TryParse(input, out index);
                index--;

                //student pick
                if (index >= 0 && index < names.Length)
                {
                    Console.WriteLine($"{names[index]} is number {numbers[index]}");
                }
                //get more information about student
                Console.WriteLine();
                Console.WriteLine("Would you like to know their hometown or favorite food?");
                Console.WriteLine("enter 'hometown' or 'food': ");
                string input2 = (Console.ReadLine());

                if (input2 == "hometown")
                {
                    Console.WriteLine($"{names[index]}'s hometown is {hometown[index]}");
                }
                else if (input2 == "food")
                {
                    Console.WriteLine($"{names[index]}'s favorite food is {food[index]}");
                }
                else
                {
                    Console.WriteLine("that was not a valid entry, try again");
                }
                Console.WriteLine("Would you like to know more?(yes or no)");
                answer = Console.ReadLine();
            } while (answer == "yes");
            

        }
    }
}
