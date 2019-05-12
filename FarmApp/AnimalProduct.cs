using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public class AnimalProduct
    {
        public string Name { get; }
        public decimal UnitPrice { get; set; }

        public AnimalProduct(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }
    }

    public class CowsProductMilk : AnimalProduct
    {
        public CowsProductMilk(decimal unitPrice) : base("Milk from cows", unitPrice) { }
    }

    public class HensProductEggs : AnimalProduct
    {
        public HensProductEggs(decimal unitPrice) : base("Eggs from hens", unitPrice) { }
    }

    public class SheepsProductWool : AnimalProduct
    {
        public SheepsProductWool(decimal unitPrice) : base("Sheep from wool", unitPrice) { }
    }
}
