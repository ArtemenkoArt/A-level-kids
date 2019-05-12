using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    abstract class Farmer //Visitor
    {
        public abstract void ActionsWithAnimals(IAnimals animal, ActionType action);
    }

    class IvanIvanovich : Farmer
    {
        readonly Farm farm;

        public IvanIvanovich(Farm farm) => this.farm = farm;

        public override void ActionsWithAnimals(IAnimals animal, ActionType action)
        {
            switch (action)
            {
                case ActionType.Collect: { farm.AnimalProductAdd(animal.ProduceProduct()); break; }
                case ActionType.Feed: { animal.Eat(animal.FavoriteFood()); break; }
                case ActionType.Walk: { animal.Walk();  break; }
                default: { break; }
            }
                
        }
    }
}
