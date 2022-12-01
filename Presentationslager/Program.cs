using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;
using System.Security.Cryptography.X509Certificates;

namespace Presentationslager
{
    public class Program
    {
        private AnvändarKontroller användarKontroller { get; set; }
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
            var a = new Program();

            Console.WriteLine("Huvudmeny");
            Console.WriteLine("1. Lista användare");
            Console.WriteLine();
            Console.WriteLine("2. Skapa en bag");
            Console.WriteLine();
            Console.WriteLine("Lägg till klubbor till din bag");
            Console.WriteLine();
            Console.WriteLine("3. Avsluta program");
            int val;
            int.TryParse(Console.ReadLine(), out val);
             
            switch(val)
            {
                case 1:
                    ListaAnvändare();
                    break;
                case 2:
                    SkapaBag();
                    break;
                case 3:
                    LäggTillKlubba();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;      
            }
        }

        static void ListaAnvändare()
        {
            var a = new Program();
            foreach (Användare användare in a.användarKontroller.HämtaAnvändare())
            {
                Console.WriteLine($"namn: {användare.Användarnamn}\tförnamn: {användare.Förnamn}\tefternamn: {användare.Efternamn}");
            }    

        }
}
}
