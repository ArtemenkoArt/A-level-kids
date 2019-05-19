using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HomeWork_20190508
{
    class FeedStock
    {
        List<AnimalFeed> animalsFeed = new List<AnimalFeed>();

        //add to the list quantity of feed
        public void Add(AnimalFeed feed, int qty) {
            for (int i = 0; i < qty; i++)
                animalsFeed.Add(feed);
        }

        //remove quantity of feed from the list
        public void Remove(AnimalFeed feed, int qty) {
            for (int i = 0; i < qty; i++)
                if (animalsFeed.Find(x => x == feed) != null)
                    animalsFeed.Remove(feed);
        }

        //Calculate the quantity of feed in stock
        public int GetQty(AnimalFeed feedt) => animalsFeed.FindAll(x => x == feedt).Count();

        //Buy food from the seller
        public void ToBuy(Seller seller, Cashbox cashbox, FeedType FeedType, int qty) {
            AnimalFeed animalFeed = seller.BuyFeed(FeedType);
            Add(animalFeed, qty);
            cashbox.Sub(animalFeed.Price * qty);
        }

        //Get feed by type
        public AnimalFeed GetFeedByType(FeedType feedType) {
            return animalsFeed.Find(x => x.FeedType == feedType);
        }
    }
}
