using System;
using System.Collections.Generic;
using System.Text;

namespace Entiteter
{
    internal class Klubba
    {
        
        public string Klubbnamn { get; set; }
        public int MaxLängd { get; set; }
        public int MinLängd { get; set; }

        public Klubba(string klubbnamn,int maxL,int minL)
        {
            
            Klubbnamn= klubbnamn;
            MaxLängd = maxL;
            MinLängd= minL;
        }
    }
}
