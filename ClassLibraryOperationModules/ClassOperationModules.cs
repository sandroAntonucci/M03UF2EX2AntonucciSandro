﻿namespace ClassLibraryOperationModules
{
    public class OperationModules
    {

        public static bool IsNatural(int num)
        {
            return num > 0;
        }

        public static bool OddNum(int num)
        {
            // Retorna true si és senar
            return num % 2 == 1;
        }

        public static int Power(int baseNum, int expNum)
        {
            int result = 1;

            for(int i = 0; i < expNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        public static int RandomNum(int minValue, int maxValue)
        {
            Random rand = new Random();

            return rand.Next(minValue, maxValue+1);
        }

        public static int CountVowelsOrConsonants(string text, bool vowelsOrConsonants)
        {
            string vowels = "aeiou";

            int vowelsCount = 0, consonantsCount = 0;

            for(int i = 0;i < text.Length;i++)
            {
                if (vowels.Contains(text[i])) vowelsCount++;
                else consonantsCount++;
            }

            return vowelsOrConsonants ? consonantsCount : vowelsCount;

        }
    }
}
