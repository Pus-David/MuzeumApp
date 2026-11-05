using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    public class mutargy
    {
        public string Azonosito { get; set; }
        protected int becsultErtek;
        public int BecsultErtek {
            get;
            set
            {
                if(value <=0)
                {
                    value = 50000;
                }
            }
        }
        private static int osszesMutargySzama;
        public static int OsszesMutargySzama { get; }

        public mutargy (string azonosito, int becsultertek, int osszesmutargy)
        {
            Azonosito = azonosito;
            BecsultErtek = becsultertek;
        }

        public virtual int BiztositasDij()
        {
            return (int)(BecsultErtek * 0.02);
        }
        public override string ToString()
        {
           return $"Műtárgy {Azonosito} | Becsült érték: {BecsultErtek} Ft | Biztosítás: {BiztositasDij()} Ft";
        }
    }
}
