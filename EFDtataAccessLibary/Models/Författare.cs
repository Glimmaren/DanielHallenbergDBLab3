using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Författare
    {
        public Författare()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }

        public Författare(string förnamn)
        {
            Förnamn = förnamn;
        }

        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }

        public override string ToString()
        {
            return $"{Förnamn} {Efternamn}";
        }
    }
}
