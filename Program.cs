using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    enum ActionType
    {
        Feed,
        Walk,
        Collect
    }

    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm();
            //Getting food for animals
            farm.AnimalFeedAdd(new Hay());
            farm.AnimalFeedAdd(new Corn());
            farm.AnimalFeedAdd(new Hay());
            //Get animals
            farm.AnimalAdd(new Cow(new Hay()));
            farm.AnimalAdd(new Chicken(new Corn()));
            farm.AnimalAdd(new Sheep(new Hay()));
            //Get farmer
            IvanIvanovich ivanIvanovich = new IvanIvanovich(farm);
            //Walk, feed, collect eggs, milk and wool
            farm.ActionsWithAnimals(ivanIvanovich, ActionType.Walk);
            farm.ActionsWithAnimals(ivanIvanovich, ActionType.Feed);
            farm.ActionsWithAnimals(ivanIvanovich, ActionType.Collect);
            //Sell ​​all that collected
            farm.AnimalProductSell();
            Console.ReadKey();
        }
    }
}
