using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna jaettava luku: ");
        double jaettava = double.Parse(Console.ReadLine());

        Console.Write("Anna jakaja: ");
        double jakaja = double.Parse(Console.ReadLine());

        double tulos = jaettava / jakaja;
        Console.WriteLine($"{jaettava} / {jakaja} = {tulos}");
    }
}
