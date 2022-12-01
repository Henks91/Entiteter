using System;
using System.Collections.Generic;
using Entiteter;


namespace Datalager
{
    public sealed class Databas
    {
        private static Databas instans = null;
        private static object lockToken = new object();

        private static List<Bag> bagar;
        private static List<Klubba> klubbor;
        private static List<KlubbTyp> klubbTyp;
        private static List<Användare> användare;


        private Databas () { }
        public static Databas Instans
        {
            get
            {
                lock (lockToken)
                {
                    instans ??= new Databas();
                }
                return instans;
            }
        }

        static Databas ()
        {
            användare = new List<Användare>()
            {
                new Användare("Bunkern", "Henric","Johansson"),
                new Användare("NCHW", "Carl", "Wånsander"),
                new Användare("Danne", "Daniel", "Noun"),
                new Användare("Fred", "Fredrik", "Linhardt")
            };

            klubbTyp = new List<KlubbTyp>()
            {
                new KlubbTyp("Driver","Trä2","Trä3","Trä4","Hybrid2","Hybrid3","Hybrid4",)
            };
            
                
           

        }


        #region Bag
        public List<Bag> HämtaBag()
        {
            return new List<Bag>(bagar);
        }

        public Bag SkapaBag(Användare användare, string bagNamn)
        {
            Bag bag = new Bag(användare, bagNamn);
            bagar.Add(bag);
            return bag;
        }

        #endregion Bag

        #region Klubba
        public List<Klubba> HämtaKlubba()
        {
            return new List<Klubba>(klubbor);
        }

        public Klubba LäggTillKlubba(string klubbnamn, int maxL, int minL)
        {
            Klubba klubba = new Klubba(klubbnamn, maxL, minL);
            klubbor.Add(klubba);
            return klubba;
        }
        #endregion Klubba

        #region Användare
        public List<Användare> HämtaAnvändare()
        {
            return new List<Användare>(användare);
        }
        public Användare HämtaAnvändare()
        {
           return användare.Find(användare=> ())
            return new List<Användare> (användare);
        }
        #endregion Användare


    }
}
