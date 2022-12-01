using System;
using System.Collections.Generic;
using System.Text;
using Entiteter;

namespace Datalager
{
    public class AnvändareRepository
    {
        private Databas databas;

        public AnvändareRepository()
        {
            databas = Databas.Instans;
        }
        public List<Användare> HämtaAnvändare()
        {
            return databas.HämtaAnvändare();
        }
       
    }
}
