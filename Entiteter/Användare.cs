using System;

namespace Entiteter
{
    public class Användare
    {
        internal string Användarnamn { get; set; }
        internal string Förnamn { get; set; }
        internal string Efternamn { get; set; }
        public Användare(string användarnamn, string förnamn, string efternamn)
        {
            Användarnamn = användarnamn;
            Förnamn = förnamn;
            Efternamn = efternamn;
    }

    }
    
}
