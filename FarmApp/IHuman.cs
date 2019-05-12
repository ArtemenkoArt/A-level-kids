using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public interface IHuman
    {
        string Name { get; set; }
        int Age { get; set; }
        FoodStack Food { get; }
        void Sleep();
        void Eat(Food food);
        void Relax();
    }
}
