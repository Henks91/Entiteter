using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entiteter
{
    public class Bag
    {
        
        public string BagNamn { get; set; }

        public List<Klubba> Klubbor { get; set; }
        public Bag(string bagNamn)
        {
            
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
