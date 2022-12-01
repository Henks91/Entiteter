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
        static void SkapaBag()
        {
            var a = new Program();
            Console.WriteLine("Namge din bag: ");
            string namn = Console.ReadLine();
            a.bagKontroller.SkapaBag(namn);
            LäggTillKlubba();
        }

        static void LäggTillKlubba()
        {
            var a = new Program();
            string Tklubba = String.Empty;
            int val;
            Console.WriteLine("Hur många klubbor vill du lägga till? ");
            int.TryParse(Console.ReadLine(), out val);

            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Namge klubban: ");
                string namn = Console.ReadLine();
                Console.WriteLine("Ange maxlängd du slår: ");
                int maxl;
                int.TryParse(Console.ReadLine(), out maxl);
                Console.WriteLine("Ange minimumlängden du slår: ");
                int minl;
                int.TryParse(Console.ReadLine(), out minl);
                a.bagKontroller.LäggTillKlubba(a.bagKontroller.SkapaBag(namn), namn, maxl, minl);
            }
            /*SlutförBag();
            foreach (Klubba klubba in )
            {

            }*/
           

            /*do
            {
                Console.WriteLine("Klubbnamn (blank rad = klar) ");
                Tklubba = Console.ReadLine();
                if (Tklubba == String.Empty)
                    break; 

                
            } while (true);*/
        }
}
}
