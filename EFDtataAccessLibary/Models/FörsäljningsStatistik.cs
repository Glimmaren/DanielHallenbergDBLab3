using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class FörsäljningsStatistik
    {
        public string Namn { get; set; }
        public decimal? TotalFörsäljning { get; set; }
        public decimal? TotmedelDagsFörsäljning { get; set; }
        public decimal? TotföregåendeÅr { get; set; }
        public decimal? TotmedleFöregåendeÅr { get; set; }
        public decimal? TotYtd { get; set; }
        public decimal? BästaDag { get; set; }
    }
}
