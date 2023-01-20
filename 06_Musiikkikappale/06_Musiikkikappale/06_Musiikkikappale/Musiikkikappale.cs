

namespace Musiikkikappale
{
    internal class Musiikkikappale
    {
        string nimi;
        int pituus;


        public Musiikkikappale(string kappaleenNimi, int kappaleenPituus)
        {
            this.nimi = kappaleenNimi;
            this.pituus = kappaleenPituus;
            
        }
        
        public string Nimi()
        {
            return nimi;
        }
        public int Pituus()
        {   

            return pituus;
        }

    }
        
}
