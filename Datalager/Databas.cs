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
    }
}
