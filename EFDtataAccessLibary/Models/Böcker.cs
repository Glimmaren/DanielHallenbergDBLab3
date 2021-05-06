using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Böcker")]
    public partial class Böcker
    {
        public Böcker()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
            Inköpsorders = new HashSet<Inköpsorder>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        [Key]
        [Column("ISBN")]
        public long Isbn { get; set; }
        [StringLength(50)]
        public string Titel { get; set; }
        [StringLength(50)]
        public string Språk { get; set; }
        [Column(TypeName = "money")]
        public decimal? Pris { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Utgivningsdatum { get; set; }
        [Column("Bokförlag(Namn)")]
        [StringLength(50)]
        public string BokförlagNamn { get; set; }

        [ForeignKey(nameof(BokförlagNamn))]
        [InverseProperty(nameof(Bokförlag.Böckers))]
        public virtual Bokförlag BokförlagNamnNavigation { get; set; }
        [InverseProperty(nameof(FörfattareBöcker.IsbnNavigation))]
        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }
        [InverseProperty(nameof(Inköpsorder.IsbnNavigation))]
        public virtual ICollection<Inköpsorder> Inköpsorders { get; set; }
        [InverseProperty(nameof(LagerSaldo.IsbnNavigation))]
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
    }
}
