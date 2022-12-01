using System;
using System.Collections.Concurrent;
using Entiteter;

namespace Affärslager
{
    public class Kontroller
    {
        public Användare SkapaAnvändare(string användarnamn, string förnamn,string efternamn)
        {
            Användare
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
    }
}
