using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class Seller
    {
        public readonly List<AnimalFeed> nomenclature = new List<AnimalFeed>();

        public Seller() {
            nomenclature.Add(new Hay());
            nomenclature.Add(new Corn());
        }

        //Find the feed in the list by type and return it
        public AnimalFeed BuyFeed(FeedType FeedType) => nomenclature.Find(x => x.FeedType == FeedType);
    }
}
