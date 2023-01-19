using System.ComponentModel.DataAnnotations;

namespace Tuote
{
    internal class Tuote
    {
        double hintaAlussa;
        int maaraAlussa;
        string nimiAlussa;

        public Tuote(double hinta,int maara, string nimi)
        { this.hintaAlussa = hinta;
            this.maaraAlussa = maara;
            this. nimiAlussa = nimi;
            
        }

        public void TulostaTuote()
        {
            Console.WriteLine(hintaAlussa);
            Console.WriteLine(maaraAlussa);
            Console.WriteLine(nimiAlussa);
        }
    }



}
