using System;

namespace QuickSort
{
    class Program
    {
        private static int[] array = new int[] { 5, 9, 3, 7, 6, 1, 2, 4, 8, 0 };
        static void Main(string[] args)
        {
            FPrint();
            Console.ReadKey();
        }
        public static void FQuickSort()
        {
            FSort(0, array.Length - 1);
        }
        public static void FSort(int left, int right)
        {
            if (left != right)
            {

            }
        }
        public static void FPrint()
        {
            string res = string.Empty;
            foreach (int val in array)
            {
                res += val + ", ";
            }
            res = res[.. ^2];
            Console.WriteLine(res);
        }
    }
}
