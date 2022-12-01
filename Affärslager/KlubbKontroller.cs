using Datalager;
using Entiteter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affärslager
{
    public class KlubbKontroller
    {
        public KlubbaRepository klubbaRepository = null;
        public KlubbKontroller() 
        {
            klubbaRepository = new KlubbaRepository();
        }    
        public Bag LäggTillKlubba(Bag bag, string klubbnamn, int maxL, int minL)
        {
            bag.LäggTillKlubba(klubbnamn, maxL, minL);
            return bag;
        }
    }
}
