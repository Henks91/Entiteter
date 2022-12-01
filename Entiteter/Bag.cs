using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entiteter
{
    public class Bag
    {
        public Användare Användare { get; private set; }
        public string BagNamn { get; set; }
        public int BagId { get; private set; }

        public List<Klubba> Klubbor { get; set; }
        public Bag(Användare användare, string bagNamn)
        {
            Användare = användare;
            BagNamn = bagNamn;
            Klubbor = new List<Klubba>();
        }
        public void LäggTillKlubba(string klubbnamn, int maxL, int minL)
        {
            Klubba klubba = new Klubba(klubbnamn, maxL, minL);
            Klubbor.Add(klubba);

        }
    }
}
