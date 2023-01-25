using System;

namespace Maksukortti
{
    class Program
    {

        static void Main(string[] args)
        {
            Maksukortti pekanKortti = new Maksukortti(20);
            Maksukortti matinKortti = new Maksukortti(30);
            pekanKortti.SyoEdullisesti();
            matinKortti.SyoMaukkaasti();
            Console.WriteLine(pekanKortti);
            Console.WriteLine(matinKortti);
            pekanKortti.LataaRahaa(20);
            matinKortti.SyoMaukkaasti();
            Console.WriteLine(pekanKortti);
            Console.WriteLine(matinKortti);
            pekanKortti.SyoEdullisesti();
            pekanKortti.SyoEdullisesti();
            matinKortti.LataaRahaa(50);
            Console.WriteLine(pekanKortti);
            Console.WriteLine(matinKortti);
        }
    }
}