using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Personal
    {
        public int Anställningsnummer { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime? Födelsedatum { get; set; }
        public int? ArbetsplatsButiksId { get; set; }

        public virtual Butiker ArbetsplatsButiks { get; set; }
    }
}
