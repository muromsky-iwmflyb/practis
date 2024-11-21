using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 / num2;
            Console.WriteLine("Результат деления: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Нельзя делить на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Ввод должен быть числом.");
        }
        finally
        {
            Console.WriteLine("Конец");
        }
    }
}