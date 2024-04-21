using System;
class Program
{
    static void Main(string[] args)
    {
        int[] elements = { 5, 3, 8, 4, 2 };
        SelectionSort(elements);

        foreach (int number in elements)
        {
            Console.Write(number + " ");
        }
    }

    public static void SelectionSort<T>(T[] arr, IComparer<T> comparer = null) where T : IComparable
    {
        if (comparer == null)
        {
            comparer = Comparer<T>.Default;
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (comparer.Compare(arr[j], arr[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            T temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}