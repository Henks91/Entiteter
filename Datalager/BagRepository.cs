using Entiteter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalager
{
    public class BagRepository
    {
        private Databas databas;

        public BagRepository()
        {
            databas = Databas.Instans;
        }
        public List<Bag> HämtaBag()
        {
            return databas.HämtaBag();
        }

        public Bag SkapaBag(string bagNamn)
        {
            return databas.SkapaBag(bagNamn);
        }

        public Bag SlutförBag(Bag bag)
        {
            return databas.SlutförBag(bag);
        }
    }
}
