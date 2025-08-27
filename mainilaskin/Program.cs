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

                break;

            case "4":
                // Jakolasku
                Console.Write("Annas luku jaettavaksi ");
                string? input1 = Console.ReadLine();

                Console.Write("Annas jakaja ");
                string? input2 = Console.ReadLine();

                if (double.TryParse(input1, out double jaettava) && double.TryParse(input2, out double jakaja))
                {
                    if (jakaja == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa");
                    }
                    else
                    {
                        double osamaara = jaettava / jakaja;
                        Console.WriteLine($"Tulos: {jaettava} / {jakaja} = {osamaara}");
                    }
                }
                break;
            default:
                Console.WriteLine("Virheellinen valinta.");
                break;


                Console.WriteLine("Paina Enter lopettaaksesi.");
                Console.ReadLine();
        }
    }
}
