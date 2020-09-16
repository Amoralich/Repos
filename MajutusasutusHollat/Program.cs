using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajutusasutusHollat
{
    class Majutusasutus
    {
        protected int _hind;
        protected int _kohti;

        public Majutusasutus(int hind, int kohti)
        {
            _hind = hind;
            _kohti = kohti;
        }

        public virtual int VabuKohti { get { return VabuKohti; } set { VabuKohti = _kohti; } }

        public virtual void ArvutaMaksumus(int külalisi)
        {
            if( külalisi > _kohti || külalisi < 0)
            {
                Console.WriteLine("Kalamajas pole nii palju vabu kohti");
            }
            else
            {
                int summa = _kohti - külalisi;
                Console.WriteLine($"Praegu hõivatakse {summa} kohta ja see läheb maksma {_hind * summa} eurot.");
            }
        }
    }
    class Hotell:Majutusasutus
    {
        protected int _tubade_arv;
        protected int _kohti_toas;

        public Hotell(int hind, int kohti, int tubade_arv, int kohti_toas) : base(hind, kohti)
        {
            _tubade_arv = tubade_arv;
            _kohti_toas = kohti_toas;
        }

        public int VabuTube { get { return VabuTube; } set { VabuTube = value; } }

        public override int VabuKohti {
            get => base.VabuKohti; set => base.VabuKohti = value;
        }

        public override void ArvutaMaksumus(int külalisi)
        {
            Console.WriteLine($"Tubasi on vaba {_tubade_arv} ja igas toas on {_kohti_toas} kohta.");
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" MajutusAsutus ");
            Majutusasutus majutusasutus = new Majutusasutus(30, 5);
            majutusasutus.ArvutaMaksumus(4);

            Console.WriteLine("");

            Console.WriteLine(" Hotell ");
            Hotell hotell = new Hotell(30, 50, 25, 2);
            hotell.ArvutaMaksumus(20);

        }
    }
}
