using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Butiker
    {
        public Butiker()
        {
            Dagsförsäljnings = new HashSet<Dagsförsäljning>();
            Inköpsorders = new HashSet<Inköpsorder>();
            LagerSaldos = new HashSet<LagerSaldo>();
            Personals = new HashSet<Personal>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Ort { get; set; }
        public string Gatuadress { get; set; }
        public int? Postkod { get; set; }

        public virtual ICollection<Dagsförsäljning> Dagsförsäljnings { get; set; }
        public virtual ICollection<Inköpsorder> Inköpsorders { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
