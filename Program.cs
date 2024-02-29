using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] resultArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Результат роботи методу:");
        foreach (int num in resultArray)
        {
            Console.Write(num + " ");
        }
    }

    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Where(num => !filterArray.Contains(num)).ToArray();
    }
}
