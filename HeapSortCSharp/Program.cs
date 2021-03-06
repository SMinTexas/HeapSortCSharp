using System;

namespace HeapSortCSharp
{
    public class HeapSort
    {
        static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                createHeap(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                createHeap(arr, i, 0);
            }
        }
        static void createHeap(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                createHeap(arr, n, largest);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100, 0, -120, -10403 };
            int n = 13, i;
            Console.WriteLine("Heap Sort");
            Console.Write("Initial Array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            heapSort(arr, n);
            Console.Write("\nSorted Array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
