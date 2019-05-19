using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    internal class Farm
    {
        internal ProductStock productStock = new ProductStock();
        internal FeedStock feedStock = new FeedStock();
        internal Cashbox cashbox = new Cashbox();
        public readonly List<Animal> animals = new List<Animal>();

        public Farm(decimal sum) => cashbox.Add(sum);

        public void Add(Animal animal) => animals.Add(animal);
        public void Remove(Animal animal) => animals.Remove(animal);
        
        //Visitor
        public void ActionsWithAnimals(Farmer farmer, ActionType action) {
            foreach (Animal animal in animals) {
                //farmer.ActionsWithAnimals(animal, action);
                animal.Accept(farmer, action);
            }
        }
    }
}
