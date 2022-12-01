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

            foreach (Användare användare in a.användarKontroller.HämtaAnvändare())
            {
              //  Console.WriteLine($"namn:{anv.Användarnamn},\tförnamn; {anv.Förnamn}, \tefternamn: {anv.Efternamn}");
                Console.WriteLine(anv);

            }
            
        }

    }
}
