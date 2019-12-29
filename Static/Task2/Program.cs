using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 4, 2, 5, 1 };

            arr = arr.MySort(true);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }

    public static class ExtensionMethods
    {
        public static int[] MySort(this int[] arr, bool side)
        {
            if (side)
            {
                Array.Sort(arr);
            }
            else
            {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
            return arr;
        }
    }
}
