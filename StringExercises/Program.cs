using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string newStr = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] newArr =new string[32];
            newArr = newStr.Split(' ');
            Console.WriteLine(newArr[1]);
            Console.WriteLine(string.Join(",", newArr));
            Console.WriteLine(string.Join(". ", newArr));
        }
    }
}
