using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajutusAsututs_Klemets
{
    class MajutusAsutus
    {
        protected decimal _price;
        protected int _spots;
        private int _guests;

        public MajutusAsutus(decimal price, int spots)
        {
            _price = price;
            _spots = spots;
        }

        public virtual int VabuKohti {
            get { return _spots - _guests; }
            set {
                if(value >= 0 && value <= _spots)
                {
                    _guests = _spots - value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("", "Vabad kohad peavad olema vahemikus 0-" + _spots);
                }
            }
        }

        public virtual int ArvutaMaksumus(int guests)
        {
            if(_guests > VabuKohti)
            {
                Console.WriteLine("Liiga palja külalisi. Vabu kohti pole");
            }
            else if(_guests < 1)
            {
                Console.WriteLine("Külaliste arv ei saa olla negativne või 0.");
            }
            else
            {
                Console.WriteLine("Price is: " + _price * _guests);
                return 1;
            }
            return 0;
        }
    }

    class Hotell:MajutusAsutus
    {
        private readonly int _rooms;
        private readonly int _roomSize;
        private int _vacancies;

        public Hotell(decimal roomPrice, int rooms, int roomSize) : base(roomPrice, rooms * roomSize)
        {
            _rooms = rooms;
            _roomSize = roomSize;
            _vacancies = rooms;
        }

        public int VabuTube {
            get {
                return _vacancies;
            }

            set {
                if(value >= 0 && value <= _rooms)
                {
                    _vacancies = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("", "Not enough rooms.");
                }
            }
        }

        public override int VabuKohti {
            get { return VabuTube * VabuKohti; }
            set {
                if(value >= 0 && value <= _spots)
                {
                    _vacancies = value / _roomSize;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("", "Not enough rooms.");
                }
            }
        }

        public override int ArvutaMaksumus(int guests)
        {
            return base.ArvutaMaksumus(guests);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Majutus Asutus");
            MajutusAsutus majutusAsutus = new MajutusAsutus(5.5m, 10);
            majutusAsutus.VabuKohti = 3;
            Console.WriteLine("Free places " + majutusAsutus.VabuKohti);
            majutusAsutus.VabuKohti = 1;
            Console.WriteLine("Free places " + majutusAsutus.VabuKohti);
            Console.WriteLine("Rooms needed " + majutusAsutus.ArvutaMaksumus(10));


            Hotell hotell = new Hotell(9.99m, 3, 100);
            hotell.VabuKohti = 300;
            Console.WriteLine("Free places: " + hotell.VabuKohti);
            Console.WriteLine("Free rooms: " + hotell.VabuTube);
        }
    }
}