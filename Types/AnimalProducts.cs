using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class AnimalsProduct
    {
        public readonly string name;
        private int Prise { get; }
        public int GetPrice() => Prise;
        public AnimalsProduct(int price, string name) { Prise = price; this.name = name; }
    }

    class Milk : AnimalsProduct
    {
        public Milk(int price, string name) : base(price, name) { }
    }

    class Wool : AnimalsProduct
    {
        public Wool(int price, string name) : base(price, name) { }
    }

    class Eggs : AnimalsProduct
    {
        public Eggs(int price, string name) : base(price, name) { }
    }
}
