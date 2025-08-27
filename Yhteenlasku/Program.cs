using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna ensimmäinen luku: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Anna toinen luku: ");
        int b = int.Parse(Console.ReadLine());

        int summa = a + b;

        Console.WriteLine($"{a} + {b} = {summa}");
    }
}