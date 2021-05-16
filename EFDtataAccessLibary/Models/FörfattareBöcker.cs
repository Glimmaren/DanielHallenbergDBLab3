using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class FörfattareBöcker
    {
        public int Id { get; set; }
        public long Isbn { get; set; }
        public int? FörfattareId { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }


    }
}
