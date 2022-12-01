using System;

namespace Entiteter
{
    public class Användare
    {
        public string Användarnamn { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public Användare(string användarnamn, string förnamn, string efternamn)
        {
            Användarnamn = användarnamn;
            Förnamn = förnamn;
            Efternamn = efternamn;
    }

    }
    
}
