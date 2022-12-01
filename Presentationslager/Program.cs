using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;

namespace Presentationslager
{
    public class Program
    {
        
        public Kontroller Kontroller { get; set; }
        
        
        public Meny() 
        {
            Kontroller = new Kontroller();
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("1. Lista användare");

            foreach (Användare användare in Databas.Instans.HämtaAnvändare())
            {
                
            }
        }

    }
}
