using System;

class QuickSort
{
    public static void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            Sort(array, low, pivotIndex - 1);
            Sort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }
        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 4, 5, 6, 7, 3, 1, 15, 10, 9, 8, 2, 11, 14, 13 };
        Sort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
