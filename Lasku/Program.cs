class Program
{
    static void Main()
    {
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
                double tulos = jaettava / jakaja;
                Console.WriteLine($"Tulos: {jaettava} / {jakaja} = {tulos}");
            }
        }
        else
        {
            Console.WriteLine("VIRHE!");
        }

        Console.ReadLine();
    }
}
