using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Personal")]
    public partial class Personal
    {
        [Key]
        public int Anställningsnummer { get; set; }
        [StringLength(50)]
        public string Förnamn { get; set; }
        [StringLength(50)]
        public string Efternamn { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Födelsedatum { get; set; }
        [Column("Arbetsplats(ButiksID)")]
        public int? ArbetsplatsButiksId { get; set; }

        [ForeignKey(nameof(ArbetsplatsButiksId))]
        [InverseProperty(nameof(Butiker.Personals))]
        public virtual Butiker ArbetsplatsButiks { get; set; }
    }
}
