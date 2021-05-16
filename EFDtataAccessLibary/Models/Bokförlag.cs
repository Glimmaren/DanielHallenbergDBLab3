using System;
using System.Collections.Generic;

#nullable disable

namespace EFDtataAccessLibary.Models
{
    public partial class Bokförlag
    {
        public Bokförlag()
        {
            Böckers = new HashSet<Böcker>();
        }

        public string Namn { get; set; }
        public string Land { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
