using System;
using Microsoft.VisualBasic;

class Laskin
{
    static void Main()
    {
        Console.WriteLine("Valitse lasku:");
        Console.WriteLine("1. Yhteenlasku");
        Console.WriteLine("2. Vähennyslasku");
        Console.WriteLine("3. Kertolasku");
        Console.WriteLine("4. Jakolasku");
        Console.Write("Valintasi (1-4): ");

        string valinta = Console.ReadLine();

        switch (valinta)
        {
            case "1":
                // Yhteenlasku
                Console.Write("Anna ensimmäinen luku: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Anna toinen luku: ");
                int b = int.Parse(Console.ReadLine());

                int summa = a + b;
                Console.WriteLine($"{a} + {b} = {summa}");
                break;

            case "2":
                // Vähennyslasku
                Console.Write("Anna ensimmäinen luku: ");
                double luku1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Anna toinen luku: ");
                double luku2 = Convert.ToDouble(Console.ReadLine());

                double tulos = luku1 - luku2;
                Console.WriteLine($"{luku1} - {luku2} = {tulos}");
                break;

            case "3":
                // Kertolasku
                Console.Write("Anna ensimmäinen luku: ");
                int c = int.Parse(Console.ReadLine());

                Console.Write("Anna toinen luku: ");
                int d = int.Parse(Console.ReadLine());

                int kertolasku = c * d;
                Console.WriteLine($"{c} * {d} = {kertolasku}");

                break;

            case "4":
                // Jakolasku
                using System;
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
}
