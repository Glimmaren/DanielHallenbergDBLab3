using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Keyless]
    public partial class FörsäljningsStatistik
    {
        [StringLength(50)]
        public string Namn { get; set; }
        [Column(TypeName = "money")]
        public decimal? TotalFörsäljning { get; set; }
        [Column("TOTMedelDagsFörsäljning", TypeName = "money")]
        public decimal? TotmedelDagsFörsäljning { get; set; }
        [Column("TOTFöregåendeÅr", TypeName = "money")]
        public decimal? TotföregåendeÅr { get; set; }
        [Column("TOTMedleFöregåendeÅr", TypeName = "money")]
        public decimal? TotmedleFöregåendeÅr { get; set; }
        [Column("TotYTD", TypeName = "money")]
        public decimal? TotYtd { get; set; }
        [Column(TypeName = "money")]
        public decimal? BästaDag { get; set; }
    }
}
