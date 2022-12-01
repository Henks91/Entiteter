using System;
using System.Collections.Generic;
using System.Text;

namespace Entiteter
{
    internal class Bag
    {
        public Användare Användare { get; private set; }
        internal string BagNamn { get; set; }
        internal int BagId { get; private set; }

        internal List<Klubbor> Klubbor { get; set; }
        public Bag(Användare användare)
        {
            Användare = användare;
            Klubbor = new List<Klubbor>();
        }
    }
}
