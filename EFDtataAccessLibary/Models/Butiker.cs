using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Butiker")]
    public partial class Butiker
    {
        public Butiker()
        {
            Dagsförsäljnings = new HashSet<Dagsförsäljning>();
            Inköpsorders = new HashSet<Inköpsorder>();
            LagerSaldos = new HashSet<LagerSaldo>();
            Personals = new HashSet<Personal>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Namn { get; set; }
        [StringLength(50)]
        public string Ort { get; set; }
        [StringLength(50)]
        public string Gatuadress { get; set; }
        public int? Postkod { get; set; }

        [InverseProperty(nameof(Dagsförsäljning.Butiks))]
        public virtual ICollection<Dagsförsäljning> Dagsförsäljnings { get; set; }
        [InverseProperty(nameof(Inköpsorder.Butiks))]
        public virtual ICollection<Inköpsorder> Inköpsorders { get; set; }
        [InverseProperty(nameof(LagerSaldo.Butiks))]
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
        [InverseProperty(nameof(Personal.ArbetsplatsButiks))]
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
