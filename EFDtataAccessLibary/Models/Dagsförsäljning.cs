using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Dagsförsäljning
    {
        public int ButiksId { get; set; }
        public decimal? Försäljning { get; set; }
        public DateTime Datum { get; set; }

        public virtual Butiker Butiks { get; set; }
    }
}
