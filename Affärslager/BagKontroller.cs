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
        public Bag SkapaBag(Användare användare, string bagNman)
        {
            return new Bag(användare, bagNman);
        }
    }
}
