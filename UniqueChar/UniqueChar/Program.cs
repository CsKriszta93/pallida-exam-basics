using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChar
{
    class Program
    {
        public static List<char> UniqueCharacters(string input)
        {
            List<char> characters = new List<char>();
            char[] lettersArr = input.ToCharArray();
            foreach (char letter in lettersArr)
            {
                if (!characters.Contains(letter))
                {
                    characters.Add(letter);
                }          
            }
            return characters;
        }

        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"
            List<char> Letters = new List<char>();
            string input = "blabla";
            Letters = UniqueCharacters(input);
            foreach (char letter in Letters)
            {                
                Console.WriteLine(letter);
            }
            Console.ReadLine();
        }
    }
}
