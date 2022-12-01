using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;

namespace Presentationslager
{
    public class Program
    {
        public AnvändarKontroller användarKontroller { get; set; }
        public BagKontroller bagKontroller { get; set; }
        public KlubbKontroller klubbKontroller { get; set; }

        public Program()
        {
            användarKontroller = new AnvändarKontroller();
            bagKontroller = new BagKontroller();
            klubbKontroller = new KlubbKontroller();
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("1. Lista användare");

            foreach (Användare användare in Databas.Instans.HämtaAnvändare())
            {
                Console.WriteLine($"namn:{användare.Användarnamn},\tförnamn; {användare.Förnamn}, \tefternamn: {användare.Efternamn}");
                Console.WriteLine();

            }
        }

    }
}
