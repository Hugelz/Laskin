using System;

class MiinusLaskin
{
    static void Main()
    {
        Console.WriteLine("Miinuslasku");

        Console.Write("Anna eka luku: ");
        string miinus1 = Console.ReadLine();
        double luku1 = Convert.ToDouble(syöte1);

        Console.Write("Anna toinen luku: ");
        string miinus2 = Console.ReadLine();
        double luku2 = Convert.ToDouble(syöte2);

        double tulos = luku1 - luku2;

        Console.WriteLine($"Tulos: {luku1} - {luku2} = {tulos}");


        Console.ReadLine();
    }
}
