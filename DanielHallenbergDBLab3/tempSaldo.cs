using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielHallenbergDBLab3
{
    public class tempSaldo
    {
        public int? Antal { get; set; }
        public string Titel { get; set; }
        public long ISBN { get; set; }

        public tempSaldo(int? antal, string titel, long isbn)
        {
            Antal = antal;
            Titel = titel;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Antal: {Antal}  Titel: {Titel}";
        }
    }
}
