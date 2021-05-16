using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielHallenbergDBLab3
{
    public class TempBook
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDay { get; set; }
        public EFDtataAccessLibary.Models.Bokförlag Publisher { get; set; }
        public List<EFDtataAccessLibary.Models.Författare> Authors { get; set; }
        public List<EFDtataAccessLibary.Models.Författare> NewAuthors { get; set; }
  

        public TempBook(long iSBN, string title, string language, decimal? price, DateTime? releaseDay, EFDtataAccessLibary.Models.Bokförlag publisher)
        {
            ISBN = iSBN;
            Title = title;
            Language = language;
            Price = price.Value;
            ReleaseDay = releaseDay.Value;
            Publisher = publisher;
            Authors = new List<EFDtataAccessLibary.Models.Författare>();
            NewAuthors = new List<EFDtataAccessLibary.Models.Författare>();

        }


    }
}
