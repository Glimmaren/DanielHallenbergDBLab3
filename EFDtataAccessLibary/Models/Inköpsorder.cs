using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Inköpsorder
    {
        public int Ordernummer { get; set; }
        public long Isbn { get; set; }
        public int? Antal { get; set; }
        public int? ButiksId { get; set; }
        public decimal? PrisÁ { get; set; }
        public DateTime? LeveransDatum { get; set; }

        public virtual Butiker Butiks { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
