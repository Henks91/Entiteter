﻿using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;

namespace Presentationslager
{
    public class Program
    {
        public Kontroller kontroller { get; set; }
        public AnvändareRepository användareRepository { get; set; }
        public BagRepository bagRepository { get; set; }
        public KlubbaRepository klubbaRepository { get; set; }

        public Program()
        {
            kontroller = new Kontroller();
            användareRepository = new AnvändareRepository();
            bagRepository = new BagRepository();
            klubbaRepository = new KlubbaRepository();
        }
        
        
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
