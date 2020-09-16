using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajutusAsutus
{
    class MajutusAsutus
    {
        protected decimal _Hind;
        protected int _Kohti;

        public MajutusAsutus(decimal Hind, int Kohti)
        {
            _Hind = Hind;
            _Kohti = Kohti;
        }

        public virtual int VabuKohti {
            get { return VabuKohti; }
            set { VabuKohti = _Kohti; }
        }

        public virtual void ArvutaMaksumus(int Külalisi)
        {

            if(Külalisi > _Kohti || Külalisi < 0)
            {

                Console.WriteLine("Vabandust aga meie hottelis ei ole nii palju kohti");
            }

            else
            {
                int summa = _Kohti - Külalisi;
                Console.WriteLine($"Praegu hõivatakse {summa} kohta ja see maksab {_Hind * summa} eurot.");
            }
        }
    }
    class Hotell:MajutusAsutus
    {
        protected int _Tubade_arv;
        protected int _Kohti_toas;
        public Hotell(decimal Hind, int Kohti, int Tubade_arv, int Kohti_toas) : base(Hind, Kohti)
        {
            _Tubade_arv = Tubade_arv;
            _Kohti_toas = Kohti_toas;
        }

        public int VabuTube {
            get { return VabuTube; }
            set { VabuTube = value; }
        }

        public override int VabuKohti {
            get => base.VabuKohti; set => base.VabuKohti = value;
        }

        public override void ArvutaMaksumus(int Külalisi)
        {
            Console.WriteLine($"Tubasi on vaba {_Tubade_arv} ja igas toas on {_Kohti_toas} kohta.");
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> MajutusAsutus <<<");
            MajutusAsutus majutusAsutus = new MajutusAsutus(15,10);
            majutusAsutus.ArvutaMaksumus(9);


            Console.WriteLine("");

            Console.WriteLine(">>> Hotell <<<");
            Hotell hotell = new Hotell(15, 5, 50, 2);
            hotell.ArvutaMaksumus(5);
        }
    }
}
