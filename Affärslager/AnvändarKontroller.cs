using Datalager;
using Entiteter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affärslager
{
    public class AnvändarKontroller
    {
        public AnvändareRepository användareRepository = null;
        public AnvändarKontroller()
        {
            användareRepository = new AnvändareRepository();
        }
        
        
        public Användare SkapaAnvändare(string användarnamn, string förnamn, string efternamn)
        {
            return new Användare(användarnamn, förnamn, efternamn);
        }
        public List<Användare> HämtaAnvändare()
        {
            return användareRepository.HämtaAnvändare();
        }
    }
}
