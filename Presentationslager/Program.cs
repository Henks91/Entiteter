using System;
using System.Collections.Generic;
using Entiteter;
using Affärslager;
using Datalager;

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

        public static Program kontext = null;
        
        static void Main(string[] args)
        {

            Console.WriteLine("Huvudmeny");
            Console.WriteLine("1. Lista användare");
            //List<Användare> användare = användarKontroller.HämtaAnvändare();
            foreach (object anv in kontext.användarKontroller.HämtaAnvändare())
            {
              //  Console.WriteLine($"namn:{anv.Användarnamn},\tförnamn; {anv.Förnamn}, \tefternamn: {anv.Efternamn}");
                Console.WriteLine(anv);

            }
        }

    }
}
