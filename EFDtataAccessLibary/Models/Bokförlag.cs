using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    [Table("Bokförlag")]
    public partial class Bokförlag
    {
        public Bokförlag()
        {
            Böckers = new HashSet<Böcker>();
        }

        [Key]
        [StringLength(50)]
        public string Namn { get; set; }
        [StringLength(50)]
        public string Land { get; set; }

        [InverseProperty(nameof(Böcker.BokförlagNamnNavigation))]
        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
