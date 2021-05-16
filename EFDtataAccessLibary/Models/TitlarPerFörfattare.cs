using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class TitlarPerFörfattare
    {
        public string Namn { get; set; }
        public int? Ålder { get; set; }
        public int? AntalTitlar { get; set; }
        public decimal? LagervärdeUtpris { get; set; }
    }
}
