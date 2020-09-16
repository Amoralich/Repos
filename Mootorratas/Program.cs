using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mootorrattas
{
    class Mootorrattas
    {
        public int Id;
        protected string _Mark;
        protected string _Model;
        private int _TopSpeed;
        private decimal _FuelType;
        private int _Mileage;
        protected string _Color;

        private static decimal _FuelType = 98;
        private static int _Mileage = 0;

        public Mootorrattas(int TopSpeed, decimal FuelType, int Mileage)
        {
            _TopSpeed = TopSpeed;
            _FuelType = FuelType;
            _Mileage = Mileage; 
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
