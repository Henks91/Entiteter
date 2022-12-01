using System;
using System.Collections.Generic;
using Entiteter;


namespace Datalager
{
    public sealed class Databas
    {
        private static Databas instans = null;
        private static object lockToken = new object();

        private static List<Bag> bag;
        private static List<Klubba> klubba;
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

        #region Bag
        public List<Bag> HämtaBag()
        {
            return new List<Bag>(bag);
        }

        public Bag SkapaBag(Bag bag)
        {

        }

        #endregion Bag

        #region Klubba
        public List<Klubba> HämtaKlubba()
        {
            return new List<Klubba>(klubba);
        }
        #endregion Klubba

        #region Användare
        public List<Användare> HämtaAnvändare()
        {
            return new List<Användare>(användare);
        }
        #endregion Användare


    }
}
