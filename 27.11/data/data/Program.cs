using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string dateString1 = "2024-11-25";
        string dateString2 = "25-11-2024";
        string dateString3 = "2025-11-25";

        Console.WriteLine("Parse()");
        DateTime parsedDate1 = DateTime.Parse(dateString1);
        Console.WriteLine(parsedDate1);

        Console.WriteLine("ParseExact()");
        DateTime parsedDate2 = DateTime.ParseExact(dateString2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(parsedDate2);

        Console.WriteLine("TryParse()");
        if (DateTime.TryParse(dateString1, out DateTime resultDate1))
        {
            Console.WriteLine(resultDate1);
        }
        else
        {
            Console.WriteLine("невозможно перевести" + dateString2 + " в dd-MM-yyyy");
        }

        Console.WriteLine("TryParseExact()");
        if (DateTime.TryParseExact(dateString3, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime resultDate2))
        {
            Console.WriteLine(resultDate2);
        }
        else
        {
            Console.WriteLine("невозможно перевести " + dateString3 + " в dd-MM-yyyy");
        }
    }
}