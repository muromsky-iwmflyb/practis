using System;
using System.Threading.Channels;


public class Calculator
{
    public int Plus(int a, int b) => a + b;
    private int Minus(int a, int b) => a - b;
    public int Minus_dostup(int a, int b) =>  Minus(a, b);
}
public class Userdata
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public void print(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
        Console.WriteLine("логин: " + Username);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Пароль: " + Password);
    }
}

class Program
    {
        static void Main()
        {
            Userdata userdata = new Userdata();
            Calculator calculator = new Calculator();
            Console.WriteLine("введите числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int plus = calculator.Plus(a, b);
            Console.WriteLine("Сумма: " + plus);
            int minus = calculator.Minus_dostup(a, b);
            Console.WriteLine("Разность: " + minus);
            Console.WriteLine("введите пароль");
            userdata.print("alex", "muromskysss@gmai.com", Console.ReadLine());
    }
    }




