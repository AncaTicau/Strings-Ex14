using System;
using System.Linq;

namespace Strings_Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "Toamna,iarna,primavara,vara";
            Console.WriteLine(GetLongestWordLength(givenString));
        }
        //Write a method that takes a list of words and returns the length of the longest one.

        public static int GetLongestWordLength(string input)
        {
            string[] words = input.Split(',');

            string longestWord = words.OrderByDescending(x => x.Length).First();

            return longestWord.Length;
        }
    }
}
