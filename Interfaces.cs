using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    interface IAnimals
    {
        AnimalsFeed FavoriteFood();
        void Walk();
        void Eat(AnimalsFeed animalsFood);
        void Voice();
        AnimalsProducts ProduceProduct();
    }

    //interface IAnimalsProduct
    //{
    //    int GetPrice();
    //}

    //interface IAnimalsFood
    //{
    //    //int GetPrice();
    //}
}
