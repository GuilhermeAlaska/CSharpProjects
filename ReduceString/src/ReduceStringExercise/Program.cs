using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReduceStringExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var inputs = SimulateInputs();
            var inputs = GetUserInputs();
            var validStrings = GetValidStrings(inputs);
            ReduceStrings(validStrings);
        }

        static List<string> SimulateInputs()
        {
            List<string> validStrings = new() { "abc", "aabc", "cabbac", "aa", "bb", "cc", "acbabcbbcbcbabacbcbbbbbbaaabadc", "bbcababccaababcacbbabca" };
            //List<string> invalidStrings = new() { "ab@c", "bc#a", "deq", "", "123", "lo&" };
            return validStrings;
        }

        public static bool StringIsValid(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            Regex rgxSpecialChar = new("[^A-Za-z0-9]");
            Regex rgxNumeric = new(@"^\d+$");

            if (rgxSpecialChar.IsMatch(str))
                return false;

            else if (rgxNumeric.IsMatch(str))
                return false;

            else if (!str.Contains("a") && !str.Contains("b") && !str.Contains("c"))
                return false;

            else
                return true;
        }

        public static bool CanReduce(List<char> charList)
        {
            char comparableChar = charList[0];

            foreach (var otherChar in charList)
            {
                if (otherChar != comparableChar)
                    return true;
            }

            return false;
        }

        public static char GetDifferentChar(char first, char second)
        {
            char[] acceptableChars = { 'a', 'b', 'c' };

            char differentChar = acceptableChars.FirstOrDefault(x => x != first && x != second);

            return differentChar;
        }

        public static string ReduceMethod(string str)
        {
            var stringInChars = str.ToCharArray();

            var charList = stringInChars.Where(x => x == 'a' || x == 'b' || x == 'c').ToList();

            for (int i = 0; i < charList.Count; i++)
            {
                if (i + 1 == charList.Count)
                    break;

                if (charList[i] == charList[i + 1])
                    continue;

                charList[i] = GetDifferentChar(charList[i], charList[i + 1]);

                charList.Remove(charList[i + 1]);
            }

            string reducedString = new(charList.ToArray());

            if (CanReduce(charList))
            {
                string strToReduce = new(charList.ToArray());

                reducedString = ReduceMethod(strToReduce);

                return reducedString;
            }

            return reducedString;
        }

        public static List<string> GetUserInputs()
        {
            var userInputs = new List<string>();

            string input;

            Console.WriteLine("Digite suas strings para serem reduzidas, depois digite 1 para iniciar o programa.");

            do
            {
                input = Console.ReadLine();

                input = input.ToLower();

                userInputs.Add(input);
            }
            while (input != "1");

            userInputs.Remove("1");

            return userInputs;
        }

        public static List<string> GetValidStrings(List<string> strings)
        {
            var validStrings = new List<string>();

            var invalidStrings = new List<string>();

            foreach (var str in strings)
            {
                if (!StringIsValid(str))
                    invalidStrings.Add(str);

                else
                    validStrings.Add(str);
            }

            PrintStrings("Strings válidas", validStrings);

            PrintStrings("Strings inválidas", invalidStrings);

            return validStrings;
        }

        public static void ReduceStrings(List<string> strings)
        {
            var reducedStrings = new List<string>();

            foreach (var str in strings)
            {
                string strReduced = ReduceMethod(str);
                reducedStrings.Add(strReduced);
            }

            PrintStrings("Strings reduzidas", reducedStrings);
        }

        public static void PrintStrings(string message, List<string> strings)
        {
            Console.WriteLine("\n" + message + "\n");

            if (strings == null)
                return;

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

    }
}