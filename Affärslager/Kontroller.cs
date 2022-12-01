using System;
using System.Collections.Concurrent;
using Entiteter;

namespace Affärslager
{
    public class Kontroller
    {
        public Bag SkapaBag(Användare användare, string bagNman)
        {
            return new Bag(användare, bagNman);
        }
    }
}
