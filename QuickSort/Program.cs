using System;

namespace QuickSort
{
    class Program
    {
        private static int[] array = new int[] { 9, 5, 9, 9, 3, 7, 6, 5, 1, 2, 4, 8, 0, 10, 11, 12 };
        static void Main(string[] args)
        {
            FPrint();
            FQuickSort();
            FPrint();
            Console.ReadKey();
        }
        public static void FQuickSort()
        {
            FSort(0, array.Length - 1); 
        }
        public static void FSort(int left, int right)
        {
            if (left < right)
            {
                int newEdge = FSwapAndGetNewEdge(left, right);
                    Console.WriteLine("new edges: " + newEdge);
                FSort(left, --newEdge);
                FSort(++newEdge, right);
            }
        }
        public static int FSwapAndGetNewEdge(int l, int r)
        {
            Console.WriteLine($"l = {l}, r = {r}");
            int edge = l - 1;
            for(int i = l; i < r; i++)
            {
                if (array[i] <= array[r])
                {
                    edge++;
                    Swap(i, edge);
                }
            }

            edge++;
            Swap(edge, r);
            return edge;

        }
        private static void Swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        public static void FPrint()
        {
                Console.WriteLine(string.Join(", ", array));
        }
    }
}
