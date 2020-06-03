using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static int[] RandomArray() 
        {
            int[] dissarray = new int[10];
            int min = 25;
            int max = 5;
            int sum = 0;
            Random rand = new Random();
            for(int i=0; i<10; i++)
            {
                dissarray[i] = rand.Next(5,26);
                sum += dissarray[i];
                if(dissarray[i] < min) 
                {
                    min = dissarray[i];
                }
                if(dissarray[i] > max) {
                    max = dissarray[i];
                }
            }
            Console.WriteLine($"min: {min}, max: {max}, sum {sum}");
            Console.WriteLine(String.Join(", ", dissarray));
            return dissarray;
        }

        public static string TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin!");
            List<string> sides = new List<string> ()
            {
                "Heads",
                "Tails"
            };
            Random rand = new Random();
            return sides[rand.Next (sides.Count)];
        }

        //Create another function called TossMultipleCoins(int num) that returns a Double
        // Have the function call the tossCoin function multiple times based on num value
        // Have the function return a Double that reflects the ratio of head toss to total toss

        public static double TossMultipleCoins(int num)
        {
            double numHeads = 0;
            for (int i=0; i<num; i++)
            {
                if (TossCoin() == "Heads")
                {
                    numHeads ++;
                    System.Console.WriteLine("Heads");
                }
                else
                {
                    System.Console.WriteLine("Tails");
                }
            }
            return numHeads/num;

        }

//         Build a function Names that returns a list of strings.  In this function:

        // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the list and print the values in the new order
        // Return a list that only includes names longer than 5 characters

        public static List<string> ShuffleNames()
        {
            List<string> Names = new List<string> ()
            {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };

                Random rand = new Random();
                for(int i=0; i<Names.Count; i++)
            {
                int randIndex = rand.Next(Names.Count);
                string temp = Names[i];
                Names[i] = Names[randIndex];
                Names[randIndex] = temp;
            }
            return Names;

        }


        static void Main(string[] args)
        {
            // RandomArray();
            // System.Console.WriteLine(TossCoin());
            // Console.WriteLine(TossMultipleCoins(10));
            Console.WriteLine(String.Join(", ", ShuffleNames()));
        }
    }
}
