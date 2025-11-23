using System;
using System.Diagnostics.Eventing.Reader;

namespace Practice
{
    internal class Program
    {
        public static string revStr(string input)
        {
            char[] str = input.ToCharArray();
            for (int i = 0; i < str.Length / 2;i++)
            {
                Char temp = str[i];
                str[i] = str[str.Length - i - 1];
                str[str.Length - i - 1] = temp;
            }
            Console.WriteLine(str);
            return  new string(str);
        }

        public static bool isPalindrome(string input)
        {
            char[] str = input.ToCharArray();
            for(int i=0;i<str.Length/2;i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool findSubString(string input, string sub)
        {
            int position = input.IndexOf(sub);
            if(position == -1) return false;
            return true;
        }
        static void Main()
        {
            string str = "Hello World";
            Console.WriteLine(findSubString(str, "lloo"));
        }
    }
}
