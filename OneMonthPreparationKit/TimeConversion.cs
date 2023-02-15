using System;
class TimeConversion
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Parse(Console.ReadLine()).ToString("HH:mm:ss"));
    }
}
