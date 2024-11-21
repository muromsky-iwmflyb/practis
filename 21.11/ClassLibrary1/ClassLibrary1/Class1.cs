using System;
namespace ClassLibrary1
{
    public class MyClass
        {
            public void PrintStr(string message)
            {
                Console.WriteLine(message);
            }

            public void PrintInt(int number)
            {
                int result = number * 2;
                Console.WriteLine("В результате выполнения операции: " + result);
            }

            public int Plus(int a, int b)
            {
                return a + b;
            }

            public string String(string name)
            {
                return $"Привет, {name}!";
            }

            public bool Bool(int number)
            {
                return number % 2 == 0;
            }
    }
}

