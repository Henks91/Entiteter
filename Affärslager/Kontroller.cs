using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Entiteter;
using Datalager;

namespace Affärslager
{
    public class Kontroller
    {
        private AnvändareRepository användareRepository = null;
        private BagRepository bagRepository = null;
        private KlubbaRepository klubbaRepository = null;

        public Kontroller() 
        {
            användareRepository = new AnvändareRepository();
            bagRepository = new BagRepository();
            klubbaRepository= new KlubbaRepository();

        }
        public Användare SkapaAnvändare(string användarnamn, string förnamn,string efternamn)
        {
            return new Användare(användarnamn, förnamn, efternamn);
        }
        public Bag SkapaBag(Användare användare, string bagNman)
        {
            return new Bag(användare, bagNman);
        }
        public Bag LäggTillKlubba(Bag bag,string klubbnamn,int maxL,int minL)
        {
            bag.LäggTillKlubba(klubbnamn, maxL, minL);
            return bag;
        }
        public List<Användare> HämtaAnvändare()
        {
            return användareRepository.HämtaAnvändare();
        }
       
	

	
    }
}
