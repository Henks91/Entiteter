using Datalager;
using Entiteter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affärslager
{
    public class BagKontroller
    {
        public BagRepository bagRepository = null;
        public BagKontroller()
        {
            bagRepository = new BagRepository();
        }
        public Bag SkapaBag(string bagNman)
        {
            return new Bag(bagNman);
        }
        
        public Bag LäggTillKlubba(Bag bag, string klubbnamn, int maxL, int minL)
        {
            bag.LäggTillKlubba(klubbnamn, maxL, minL);           
            return bag;
        }
        public Bag SlutförBag(Bag bag)
        {
            return bagRepository.SlutförBag(bag);
        }
    }
}
