using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Författare")]
    public partial class Författare
    {
        public Författare()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Förnamn { get; set; }
        [StringLength(50)]
        public string Efternamn { get; set; }
        [Column(TypeName = "date")]
        public DateTime Födelsedatum { get; set; }

        [InverseProperty(nameof(FörfattareBöcker.Författare))]
        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }

        public override string ToString()
        {
            return $"{Förnamn} {Efternamn}";
        }
    }
}
