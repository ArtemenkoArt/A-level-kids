using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    interface IAnimal
    {
        //
    }

    interface IAnimalFood
    {
        //
    }

    interface IAnimalProduct
    {
        //
    }

    interface INomenclature
    {
        void Plus(decimal qty);
        void Minus(decimal qty);
        decimal GetQty();
        decimal GetSum();
    }
}
