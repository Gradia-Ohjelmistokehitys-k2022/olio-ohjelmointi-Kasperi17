using System;

namespace Musiikkikappale
{
    class Program
    {
        static void Main(string[] args)
        {
            Musiikkikappale garden = new Musiikkikappale("HeiMoiTervehdys", 10910);
            Console.WriteLine("Kappaleen " + garden.Nimi() + " pituus on " + garden.Pituus() + " sekuntia.");

        }
    }
}