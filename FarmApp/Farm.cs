using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public class Farm
    {
        public Farmer Farmer { get; }
        private List<IHuman> Suppliers;
        public List<Animal> Animals { get; set; }
        public List<AnimalProduct> Products { get; set; }

        public Farm()
        {
            Farmer = new Farmer("Ivo Bobul", 77);
            Suppliers = new List<IHuman>();
            Animals = new List<Animal>();
            Products = new List<AnimalProduct>();
        }

    }
}
