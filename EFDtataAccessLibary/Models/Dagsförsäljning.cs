using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Dagsförsäljning")]
    [Index(nameof(ButiksId), Name = "PK, FK")]
    public partial class Dagsförsäljning
    {
        [Key]
        [Column("ButiksID")]
        public int ButiksId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Försäljning { get; set; }
        [Key]
        [Column(TypeName = "date")]
        public DateTime Datum { get; set; }

        [ForeignKey(nameof(ButiksId))]
        [InverseProperty(nameof(Butiker.Dagsförsäljnings))]
        public virtual Butiker Butiks { get; set; }
    }
}
