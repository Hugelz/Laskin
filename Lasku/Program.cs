using System;

class JakoLaskin
{
    static void Main()
    {
        Console.WriteLine("Jakolasku");

        Console.Write("Jaettava luku: ");
        string? jaettavaStr = Console.ReadLine();
        double jaettava = Convert.ToDouble(jaettavaStr);

        Console.Write("Jakaja: ");
        string? jakajaStr = Console.ReadLine();
        double jakaja = Convert.ToDouble(jakajaStr);

        double tulos = jaettava / jakaja;

        Console.WriteLine($"Tulos: {jaettava} / {jakaja} = {tulos}");

        Console.ReadLine();
    }
}
