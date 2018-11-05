using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MIdTerm
{
    public static class Validator
    {

        public static string GetString(string message, string regExpect)
        {
            //verify that a string is formatted as expected
            while (true)

            {
                Console.WriteLine(message);

                string words = Console.ReadLine();

                if (Regex.IsMatch(words, regExpect))
                {
                    return words;

                }
                else
                {
                    continue;
                }
            }
        }


        public static int GetNumber(string message, int minValue, int maxValue)
        {
            //verify input is a number and within boundaries
            while (true)

            {
                Console.WriteLine(message);

                int number;

                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number, no letters or symbols!");
                    continue;
                }

                if (number < minValue || number > maxValue)
                {
                    continue;
                }
                else
                {
                    return number;
                }
            }
        }



        public static bool GetAnyCaseChar(string message, char lowerCase, char upperCase)
        {
            //verify a requested letter key is pressed, regardless of case

            Console.WriteLine(message);

            char testChar = Console.ReadKey(true).KeyChar;

            if (testChar == lowerCase || testChar == upperCase)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public static char GetAnyCaseChar(string message, char[] lowerCase, char[] upperCase)
        {   //overload
            //verify a requested letter key is pressed, regardless of case - from a list of char letters
            //returns pressed key in lower case
            while (true)
            {
                Console.WriteLine(message);

                char testChar = Console.ReadKey(true).KeyChar;

                foreach (char character in lowerCase)
                {
                    if (testChar == character)
                    {
                        return testChar;
                    }
                }

                foreach (char character in upperCase)
                {
                    if (testChar == character)
                    {
                        string temp = testChar.ToString();

                        temp.ToLower();

                        char newTestChar = temp[0];

                        return newTestChar;
                    }
                }


            }

        }

    }
}
