using System;

namespace Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka raha = new Velka(100, 0.05);
            raha.TulostaSaldo();
            raha.OdotaVuosi();
            raha.TulostaSaldo();
            

            
        }
    }
}