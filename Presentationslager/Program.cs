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
            var a = new Program();

            Console.WriteLine("Huvudmeny");
            Console.WriteLine("1. Lista användare");
            Console.WriteLine("2. Skapa användare");
            Console.WriteLine("3. Skapa bag");

            

        }





        





            static void ListaAnvändare()
            {
                var a = new Program();
                foreach (Användare användare in a.användarKontroller.HämtaAnvändare())
                {
                    Console.WriteLine($"namn:{användare.Användarnamn},\tförnamn; {användare.Förnamn}, \tefternamn: {användare.Efternamn}");
                    Console.WriteLine();

                }
            }
            static void AdderaKlubba()
            {

            }
            
            
        }

    }
}
