using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello, World!";
        string str2 = "Hello, World!";
        string str3 = "hello, world!";
        string str4 = "Goodbye, World!";

        if (str1 == str2)
        {
            Console.WriteLine("str1 и str2 равны");
        }
        else
        {
            Console.WriteLine("str1 и str2 не равны");
        }

        if (str1.Equals(str3))
        {
            Console.WriteLine("str1 и str3 равны");
        }
        else
        {
            Console.WriteLine("str1 и str3 не равны");
        }

        int comparisonResult = string.Compare(str1, str3);
        if (comparisonResult < 0)
        {
            Console.WriteLine("str1 меньше str3");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("str1 больше str3");
        }
        else
        {
            Console.WriteLine("str1 равен str3");
        }

        int ordinalResult = string.CompareOrdinal(str1, str3);
        if (ordinalResult < 0)
        {
            Console.WriteLine("str1 меньше str3 по локали");
        }
        else if (ordinalResult > 0)
        {
            Console.WriteLine("str1 больше str3 по локали");
        }
        else
        {
            Console.WriteLine("str1 равен str3");
        }

        int index = str1.IndexOf("World");
        if (index != -1)
        {
            Console.WriteLine("Подстрока 'World' найдена в str1 по индексу " + index);
        }
        else
        {
            Console.WriteLine("Подстрока 'World' не найдена в str1");
        }

        if (str1.Contains("Hello"))
        {
            Console.WriteLine("str1 содержит 'Hello'");
        }
        else
        {
            Console.WriteLine("str1 не содержит 'Hello'");
        }

        if (str1 != str4)
        {
            Console.WriteLine("str1 и str4 не равны");
        }
    }
}