using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReduceString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas strings, depois pressione 1 para executar\n");

            //var userInputs = new List<string>();
            //string input;

            //do
            //{
            //    input = Console.ReadLine();
            //    userInputs.Add(input);
            //}
            //while (input != "1");
            //userInputs.Remove(input);

            var userInputs = SimulateInputs();

            var invalidStrings = new List<string>();

            for (int i = 0; i < userInputs.Count; i++)
            {
                if (!IsValid(userInputs[i]))
                {
                    invalidStrings.Add(userInputs[i]);
                }
            }

            if (invalidStrings.Count > 0)
            {
                for (int i = 0; i < invalidStrings.Count; i++)
                {
                    userInputs.Remove(invalidStrings[i]);
                }
            }
            Console.WriteLine("\nStrings invalidas: \n");
            foreach (var item in invalidStrings)
            {
                Console.WriteLine(item);
            }

            var originalUserStrings = userInputs.GetRange(0, userInputs.Count);

            var reducedStrings = new List<string>();

            foreach (var item in userInputs)
            {
                reducedStrings.Add(ReduceString(item));
            }

            Console.WriteLine("\nStrings inputadas: \n");
            foreach (var item in originalUserStrings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nStrings reduzidas: \n");
            foreach (var item in reducedStrings)
            {
                Console.WriteLine(item + " count: " + item.Length);
            }
        }

        public static bool IsValid(string input)
        {
            Regex rgxSpecialChar = new Regex("[^A-Za-z0-9]");
            Regex rgxNumeric = new Regex(@"^\d+$");

            if (input == "")
                return false;

            var hasSpecialChars = rgxSpecialChar.IsMatch(input);
            if (hasSpecialChars)
                return false;

            var hasNumbers = rgxNumeric.IsMatch(input);
            if (hasNumbers)
                return false;

            if (!input.Contains("a") && !input.Contains("b") && !input.Contains("c"))
                return false;

            return true;
        }
        public static string ReduceString(string input)
        {
            input = input.ToLower();
            char[] stringInputInChars = input.ToCharArray();
            var charList = new List<char>();

            charList = stringInputInChars.Where(x => x == 'a' || x == 'b' || x == 'c').ToList();

            for (int i = 0; i < charList.Count; i++)
            {
                if (i + 1 > charList.Count - 1)
                {
                    break;
                }

                if (charList[i] == charList[i + 1])
                    continue;

                charList[i] = GetDifferentChar(charList[i], charList[i + 1]);
                charList.Remove(charList[i + 1]);
            }

            for (int i = 0; i < charList.Count; i++)
            {
                if (i + 1 > charList.Count - 1)
                {
                    if (charList.Count < 2)
                        break;

                    if (charList.Count != 2)
                    {
                        charList[0] = GetDifferentChar(charList[0], charList[1]);
                        charList.Remove(charList[1]);
                    }
                    break;
                }

                if (charList[i] == charList[i + 1])
                    continue;

                charList[i] = GetDifferentChar(charList[i], charList[i + 1]);
                charList.Remove(charList[i + 1]);

                if (charList.Count == 2)
                {
                    if (charList[0] != charList[1])
                    {
                        var temp = GetDifferentChar(charList[0], charList[1]);
                        charList.Clear();
                        charList.Add(temp);
                    }
                }
            }

            var result = new string(charList.ToArray());
            return result;
        }
        public static char GetDifferentChar(char first, char second)
        {
            char[] acceptableChars = { 'a', 'b', 'c' };
            foreach (var character in acceptableChars)
            {
                if (first != character && second != character)
                    return character;
            }
            return 'g';
        }

        static List<string> SimulateInputs()
        {
            List<string> fakeInputs = new() { "abc", "aabc", "cabbac", "aa", "bb", "cc", "%asd", "zzz" }; //cc a cc aa bb cc a 
            return fakeInputs;
        }
    }
}