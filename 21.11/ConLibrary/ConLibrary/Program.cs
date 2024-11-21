using System;
using ClassLibrary1;

namespace MyLibraryTester
{
    class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            class1.PrintStr("Строка");
            class1.PrintInt(5);
            int sum = class1.Plus(3, 7);
            Console.WriteLine("Сумма: " + sum);
            string helloName = class1.String("Саша");
            Console.WriteLine(helloName);
            bool tr = class1.Bool(8);
            Console.WriteLine("Четное ли число 8? " + tr);
        }
    }
}