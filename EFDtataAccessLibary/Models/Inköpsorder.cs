using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Inköpsorder")]
    [Index(nameof(Isbn), Name = "PK, FK")]
    public partial class Inköpsorder
    {
        [Key]
        public int Ordernummer { get; set; }
        [Key]
        [Column("ISBN")]
        public long Isbn { get; set; }
        public int? Antal { get; set; }
        [Column("ButiksID")]
        public int? ButiksId { get; set; }
        [Column("Pris á", TypeName = "money")]
        public decimal? PrisÁ { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LeveransDatum { get; set; }

        [ForeignKey(nameof(ButiksId))]
        [InverseProperty(nameof(Butiker.Inköpsorders))]
        public virtual Butiker Butiks { get; set; }
        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Böcker.Inköpsorders))]
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
