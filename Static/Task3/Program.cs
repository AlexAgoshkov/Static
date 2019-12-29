using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "asdsad";

            string b = a.MySubstring(1, 3);

            int c = a.MyIndexOf('d');

            string d = a.MyReplace('s', '2');

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.ReadKey();
        }

       
    }

    public static class ExtensionMethods
    {
        public static string MySubstring(this string text, int startIndex, int lenght)
        {
            char[] arr = text.ToCharArray();

            string str = ""; 

            for (int i = startIndex; i < lenght+1; i++)
            {
                str += arr[i];
            }

            return str;
        }

        public static int MyIndexOf(this string text, char symbol)
        {
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    index = i;
                    break;
                }    
            }

            return index;
        }

        public static string MyReplace(this string text, char old, char symbol)
        {
            char[] arr = text.ToCharArray();

            string str = "";
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == old)
                {
                    arr[i] = symbol;
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i];
            }

            return str;
        }

    }

}
