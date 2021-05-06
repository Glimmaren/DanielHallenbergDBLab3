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
        public string AuthorName { get; set; }
        public string AuthorFirstName { get; set; }
        public int AuthorID { get; set; }

        public TempBook(long iSBN, string title, string language, decimal? price, DateTime? releaseDay, EFDtataAccessLibary.Models.Bokförlag publisher, string authorFirstName, string authorsLastName, int authorID)
        {
            ISBN = iSBN;
            Title = title;
            Language = language;
            Price = price.Value;
            ReleaseDay = releaseDay.Value;
            Publisher = publisher;
            AuthorName = authorFirstName + " " + authorsLastName;
            AuthorID = authorID;
        }

    }
}
