using System;
using ClassLibrary1;

namespace MyLibraryTester
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.PrintStr("Строка");
            myClass.PrintInt(5);
            int sum = myClass.Plus(3, 7);
            Console.WriteLine("Сумма: " + sum);
            string helloName = myClass.String("Саша");
            Console.WriteLine(helloName);
            bool tr = myClass.Bool(8);
            Console.WriteLine("Четное ли число 8? " + tr);
        }
    }
}