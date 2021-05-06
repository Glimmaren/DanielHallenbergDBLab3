using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Författare_Böcker")]
    [Index(nameof(Isbn), nameof(FörfattareId), Name = "PK, FK")]
    public partial class FörfattareBöcker
    {
        [Key]
        [Column("ISBN")]
        public long Isbn { get; set; }
        [Key]
        [Column("FörfattareID")]
        public int FörfattareId { get; set; }

        [ForeignKey(nameof(FörfattareId))]
        [InverseProperty("FörfattareBöckers")]
        public virtual Författare Författare { get; set; }
        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Böcker.FörfattareBöckers))]
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
