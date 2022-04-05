using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public static class ExtensionMethod
    {

        public static bool CustomContains(this string word, string find)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == find[0])
                {
                    for (int j = 1; j < find.Length; j++)
                    {
                        if (i + j < word.Length)
                        {
                            if (word[i + j] == find[j])
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == find.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CustomContains(this string word, char find)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == find)
                {
                    return true;
                }

            }
            return false;

        }
        public static bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}


