namespace Maksukortti
{
    public class Maksukortti
    {
        private double saldo;

        public Maksukortti(double alkusaldo)
        {
            saldo = alkusaldo;
        }

        public override String ToString()
        {
            return "kortilla on rahaa " + saldo + " euroa";
        }

        public void SyoEdullisesti()
        {
            if (saldo >= 2.60)
            {
                saldo = saldo - 2.60;
            }

        }

        public void SyoMaukkaasti()
        {
            if (saldo >= 2.60)
            {
                saldo = saldo - 4.60;
            }

        }
        public void LataaRahaa(double lisaa)
        {
            if (lisaa < 0)
            {
                lisaa = 0;
            }
            saldo = saldo + lisaa;
            
            
        }
        
        








    }

}


