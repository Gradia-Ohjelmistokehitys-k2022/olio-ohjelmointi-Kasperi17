using Eläin_Kirjasto;
using Elain_Kirjasto;

namespace PennutjaEmot
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa ema1 = new Kissa { Nimi = "Ema 1" };
            Kissa ema2 = new Kissa { Nimi = "Ema 2" };

            for (int i = 0; i < 3; i++)
            {
                ema1.LisaaPentu();
                ema2.LisaaPentu();
            }

            Console.WriteLine($"Ema 1:n pentuja: {ema1.Pennut.Count}");
            Console.WriteLine($"Ema 2:n pentuja: {ema2.Pennut.Count}");

            foreach (Kissa pentu in ema1.Pennut)
            {
                Console.WriteLine($"{pentu.Nimi}: emä = {pentu.Ema.Nimi}");
            }

            foreach (Kissa pentu in ema2.Pennut)
            {
                Console.WriteLine($"{pentu.Nimi}: emä = {pentu.Ema.Nimi}");
            }
        }
    }
}



