using Entiteter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalager
{
    public class KlubbaRepository
    {
        private Databas databas;

        public KlubbaRepository()
        {
            databas = Databas.Instans;
        }
        public List<Klubba> HämtaKlubba()
        {
            return new List<Klubba>();
        }

        public Klubba LäggTillKlubba(string klubbnamn, int maxL, int minL)
        {
            return databas.LäggTillKlubba(klubbnamn, maxL, minL);
        }
    }
}
