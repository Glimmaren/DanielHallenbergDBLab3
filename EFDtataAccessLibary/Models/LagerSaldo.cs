using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("LagerSaldo")]
    [Index(nameof(ButiksId), nameof(Isbn), Name = "PK, FK")]
    public partial class LagerSaldo
    {
        [Key]
        [Column("ButiksID")]
        public int ButiksId { get; set; }
        [Key]
        [Column("ISBN")]
        public long Isbn { get; set; }
        public int? Antal { get; set; }

        [ForeignKey(nameof(ButiksId))]
        [InverseProperty(nameof(Butiker.LagerSaldos))]
        public virtual Butiker Butiks { get; set; }
        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Böcker.LagerSaldos))]
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
