using System;

namespace MethodExercise
{
    class Program
    {
        // string ---> string
        // Takes in a query and returns the user's response in a sentence.
        //Examples:
        // "name" ----> "My name is {user response}."
        // "favorite band" ----> "My favorite band is {user response}."
        // "hair color" ----> "My hair color is {user response}."
        static string getAnswer( string query)
        {
            Console.WriteLine($"What is your {query}?");
            string resp = Console.ReadLine();
            return $"My {query} is {resp}. ";
        }


        //int int int ... | int[] ---> int
        //Takes in ints and returns the sum of all inputs
        //Examples:
        //10 -> 10
        //10, 5 -> 15
        //10, 5, 2 -> 17
        //[10, 5, 2] -> 17
        static int Add( params int[] adders )
        {
            int sum = 0;
            for (int i = 0; i < adders.Length; i++)
            {
                sum += adders[i];
            }
            return sum;
        }

        //int int int ... | int[] ---> int
        //Takes in ints and subtracts from the first int the rest of the ints
        //Examples:
        //10 -> 10
        //10, 5 -> 5
        //10, 5, 2 -> 3
        //[10, 5, 12] -> 3
        static int Subtract(params int[] subtracts)
        {
            int diff = subtracts[0];
            for (int i = 1; i < subtracts.Length; i++)
            {
                diff -= subtracts[i];
            }
            return diff;
        }

        //int int int ... | int[] ---> int
        //Takes in ints and returns the product of all inputs
        //Examples:
        //10 -> 10
        //10, 5 -> 50
        //10, 5, 2 -> 100
        //[10, 5, 2] -> 100
        static int Multiply(params int[] mults)
        {
            int prod = 1;
            for (int i = 0; i < mults.Length; i++)
            {
                prod = prod * mults[i];
            }
            return prod;
        }

        //int int int ... | int[] ---> int
        //Takes in ints and returns the first int divide by the next, and then
        //  the result by the next, etc.
        //Examples:
        //10 -> 10
        //10, 5 -> 2
        //10, 5, 2 -> 1
        //[10, 5, 2] -> 1
        static int Divide(params int[] divs)
        {
            int quot = divs[0];
            for (int i = 1; i < divs.Length; i++)
            {
                quot = quot / divs[i];
            }
            return quot;
        }

        //int int int ... | int[] ---> int
        //Takes in ints and returns the modulo of the first int by the second,
        // then the result by the third, etc.
        //Examples:
        //26 -> 26
        //26, 7 -> 5
        //26, 7, 2 -> 1
        //[26, 7, 2] -> 1
        static int Modulo(params int[] mods)
        {
            int rem = mods[0];
            for (int i = 1; i < mods.Length; i++)
            {
                rem = rem % mods[i];
            }
            return rem;
        }

        static void Main(string[] args)
        {
            string name = getAnswer("name");
            string band = getAnswer("favorite band");
            string animal = getAnswer("favorite animal");
            string color = getAnswer("favorite color");
            Console.WriteLine(name + band + animal + color);

            int ex1 = 10;
            int ex2 = 5;
            int ex3 = 2;
            int[] modExs = { 26, 7, 2 };
            int added = Add(ex1, ex2, ex3);
            int subbed = Subtract(ex1, ex2, ex3);
            int multed = Multiply(ex1, ex2, ex3);
            int divved = Divide(ex1, ex2, ex3);
            int modded = Modulo(modExs);

            Console.WriteLine($"As predicted, 17 = {added}");
            Console.WriteLine($"As predicted, 3 = {subbed}");
            Console.WriteLine($"As predicted, 100 = {multed}");
            Console.WriteLine($"As predicted, 1 = {divved}");
            Console.WriteLine($"As predicted, 1 = {modded}");
        }
    }
}
