using System;

class Program
{
    static void SortV(int[] array)
    {
        Array.Sort(array);
    }

    static void SortU(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    static int[] Arrays(int[] array1, int[] array2)
    {
        int[] Arrayss = new int[array1.Length + array2.Length];
        Array.Copy(array1, Arrayss, array1.Length);
        Array.Copy(array2, 0, Arrayss, array1.Length, array2.Length);
        return Arrayss;
    }

    public static int AbsDiff(int n)
    {
        int diff = Math.Abs(n - 123);
        if (n > 123)
        {
            return 3 * diff;
        }
        return diff;
    }

    static void Main()
    {
        Console.WriteLine("#1");
        int[] array1 = { 5, 4, 23, 2, 10 };
        int[] array2 = { 4, 7, 3, 1 };
        SortV(array1);
        Console.WriteLine("Массив 1 отсортирован по возрастанию " + string.Join(" ", array1));
        SortU(array2);
        Console.WriteLine("Массив 2 отсортирован по убыванию " + string.Join(" ", array2));
        int[] Arrayss = Arrays(array1, array2);
        Console.WriteLine("объедененные массивы " + string.Join(" ", Arrayss));
        Console.WriteLine("#2");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = AbsDiff(n);
        Console.WriteLine("Абсолютная разность для " + n + ": " + result);
    }
}
