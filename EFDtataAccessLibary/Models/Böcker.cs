using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Böcker
    {
        public Böcker()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
            Inköpsorders = new HashSet<Inköpsorder>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public long Isbn { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public decimal? Pris { get; set; }
        public DateTime? Utgivningsdatum { get; set; }
        public string BokförlagNamn { get; set; }

        public virtual Bokförlag BokförlagNamnNavigation { get; set; }
        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }
        public virtual ICollection<Inköpsorder> Inköpsorders { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
    }
}
