using System;
using System.Security.Cryptography.X509Certificates;

namespace _01_kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            kissa naapurinKissa = new kissa();
            kissa omakissa = new kissa(10,"Pekka");
            kissa katti = new kissa();

            omakissa.AsetakissanIka(10);
            Console.WriteLine(naapurinKissa);
            Console.WriteLine(omakissa.Nimi);
            Console.WriteLine(omakissa.PalautaKissanIka());
            Console.WriteLine(naapurinKissa.PalautaKissanIka());
            Console.WriteLine(omakissa.AsetaKissanNimi("hildA"));
            Console.WriteLine(katti);
            Console.WriteLine(omakissa);
            Console.WriteLine(naapurinKissa);
            
            
            
            



        }
    }
}
