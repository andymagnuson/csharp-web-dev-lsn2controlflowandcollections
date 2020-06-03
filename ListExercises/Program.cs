using System;
using System.Collections.Generic;

namespace ListExercises
{
    public static class sum
     {
      public static double Summm(List<double> list1)
        {
            double total = 0;
            foreach(double i in list1)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
        public static string GetWordByLength(double num1, List<string> list1)
        {
            foreach (string word in list1)
            {
                if (word.Length == num1)
                {
                    Console.Write(word + " ");
                }
            }
            return "";
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            List<double> newList = new List<double> { 1, 3, 4, 5, 6, 7, 8, 9, 34, 1, 23, 3 };
            List<string> stringList = new List<string> { "james", "Andy", "Hello", "Boy", "peach", "Soccer" };
            Console.WriteLine(sum.Summm(newList));
            Console.WriteLine("Please enter a number: ");
            int input =int.Parse(Console.ReadLine());
            Console.WriteLine(sum.GetWordByLength(input, stringList));
        }   
    }
}
