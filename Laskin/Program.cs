using System;

class MiinusLaskin
{
    static void Main()
    {
        Console.WriteLine("Miinuslasku");

        Console.Write("Eka luku: ");
        string miinus1 = Console.ReadLine();
        double luku1 = Convert.ToDouble(miinus1);

        Console.Write("Toka luku: ");
        string miinus2 = Console.ReadLine();
        double luku2 = Convert.ToDouble(miinus2);

        double tulos = luku1 - luku2;

        Console.WriteLine($"Tulos: {luku1} - {luku2} = {tulos}");


        Console.ReadLine();
    }
}
