using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Keyless]
    public partial class TitlarPerFörfattare
    {
        [Required]
        [StringLength(101)]
        public string Namn { get; set; }
        public int? Ålder { get; set; }
        public int? AntalTitlar { get; set; }
        [Column("Lagervärde(Utpris)", TypeName = "money")]
        public decimal? LagervärdeUtpris { get; set; }
    }
}
