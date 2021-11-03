using System;

namespace QuickSort
{
    class Program
    {
        private static int[] array = new int[] { 5, 9, 3, 7, 6, 1, 2, 4, 8, 0 };
        static void Main(string[] args)
        {
            FPrint();
            FQuickSort();
            Console.ReadKey();
        }
        public static void FQuickSort()
        {
            FSort(0, array.Length - 1); 
        }
        public static void FSort(int left, int right)
        {
            int pivot;
            if (left != right)
            {
                pivot = left + (right - left) / 2;
                    Console.WriteLine($"Pivot = {pivot}. for l = {left} and r = {right}. Val = {array[pivot]}" );
                    Console.WriteLine("FSwap begining...");
                    Console.WriteLine();
                int newEdge = FSwapAndGetNewEdge(left, right, array[pivot]);
                    Console.WriteLine("new edges: " + newEdge);
                FSort(left, newEdge);
                FSort(++newEdge, right);
            }
        }
        public static int FSwapAndGetNewEdge(int l, int r, int val)
        {
            if (l >= r)
            {
                return l;
            }
            while ((l < r) && (array[l] < val || array[r] > val ))
            {
                if (array[r] > val)
                {
                    r--;
                }
                if (array[l] <= val && r > l)
                {
                    l++;
                }
                    Console.WriteLine("one pass completed");
            }
                Console.WriteLine($"change indexes {l} and {r}. Values {array[l]} and { array[r]}");
            if (l != r)
            {
                int temp = array[l];
                array[l] = array[r];
                array[r] = temp;
            }
                Console.WriteLine("array after swap:");
            FPrint();
            return FSwapAndGetNewEdge(l, r, val);
        }
        public static void FPrint()
        {
                Console.WriteLine(string.Join(", ", array));
        }
    }
}
