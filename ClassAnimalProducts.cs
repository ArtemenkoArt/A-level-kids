using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class AnimalsProducts
    {
        public readonly string name;
        private int Prise { get; }
        public int GetPrice() => Prise;
        public AnimalsProducts(int price, string name) { Prise = price; this.name = name; }
    }

    class Milk : AnimalsProducts
    {
        public Milk(int price, string name) : base(price, name) { }
    }

    class Wool : AnimalsProducts
    {
        public Wool(int price, string name) : base(price, name) { }
    }

    class Eggs : AnimalsProducts
    {
        public Eggs(int price, string name) : base(price, name) { }
    }
}
