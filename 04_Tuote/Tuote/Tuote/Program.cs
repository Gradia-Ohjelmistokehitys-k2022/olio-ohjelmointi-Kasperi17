using System;
using System.Runtime.CompilerServices;

namespace Tuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote peruna = new Tuote(1.5,3,"peruna");
            peruna.TulostaTuote();
            Tuote banaani = new Tuote(1.5, 5, "banaani");
            banaani.TulostaTuote();
        }
    }
}
