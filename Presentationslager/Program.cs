using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;

namespace Presentationslager
{
    public class Meny
    {
        
        public Kontroller Kontroller { get; set; }
        
        
        public Meny() 
        {
            Kontroller = new Kontroller();
        }

        
        static void Main(string[] args)
        {

            foreach (Användare a in Kontroller.HämtaAnvändare())
            {
                Console.WriteLine(a.Förnamn);
            }
            Kontroller.LäggTillKlubba()

            
        }

    }
}
