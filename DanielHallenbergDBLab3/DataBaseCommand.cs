using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielHallenbergDBLab3
{
    public class DataBaseCommand
    {

        public static List<EFDtataAccessLibary.Models.Butiker> PopulateButiker()
        {

            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var butiksLista = context.Butikers.ToList();

                return butiksLista;
            }

        }
        public static List<tempSaldo> GetSlado(int butiksID)
        {
            List<tempSaldo> tempSaldos = new List<tempSaldo>();

            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {

                var lagerSaldo = (from Böcker in context.Böckers
                                  join LagerSaldo in context.LagerSaldos on Böcker.Isbn equals LagerSaldo.Isbn
                                  join Butiker in context.Butikers on LagerSaldo.ButiksId equals Butiker.Id
                                  where (LagerSaldo.ButiksId == butiksID)
                                  select new { Antal = LagerSaldo.Antal, Titel = Böcker.Titel, ISBN = LagerSaldo.Isbn }).ToList();

                foreach (var item in lagerSaldo)
                {
                    tempSaldos.Add(new tempSaldo(item.Antal, item.Titel, item.ISBN));
                }

                return tempSaldos;
            }
        }
        public static Boolean ChangeSaldo(int ammount, long isbn, int storeNr)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var saldo = context.LagerSaldos.FirstOrDefault(a => a.Isbn == isbn && a.ButiksId == storeNr);

                if(saldo != null)
                {
                    saldo.Antal = saldo.Antal + ammount;

                    if(saldo.Antal >= 0)
                    {
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
        public static List<EFDtataAccessLibary.Models.Författare> GetFörfattare()
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var författList = context.Författares.ToList();

                return författList;
            }
        }
        public static EFDtataAccessLibary.Models.Författare ShowAuthor(int id)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var author = context.Författares.FirstOrDefault(a => a.Id == id);

                return author;
            }
                
        }
        public static Boolean UpdateAuthor(EFDtataAccessLibary.Models.Författare author)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var authors = context.Författares.FirstOrDefault(a => a.Id == author.Id);

                authors.Förnamn = author.Förnamn;
                authors.Efternamn = author.Efternamn;
                authors.Födelsedatum = author.Födelsedatum;

                context.SaveChanges();
            }

            return true;
        }
        public static Boolean CreateAuthor(EFDtataAccessLibary.Models.Författare author)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {

                if(context.Författares.FirstOrDefault(a => a.Förnamn == author.Förnamn).Equals(author))
                {
                    return false;
                }
                else
                {
                    context.Författares.Add(author);
                    context.SaveChanges();
                    return true;
                }                               
            }
        }      
        public static Boolean DeleteAuthor(int id)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var author = context.Författares.FirstOrDefault(a => a.Id == id);
                context.Remove(author);
                context.SaveChanges();
                return true;
            }
        } //Detta är en bool i förebyggande syfte!
        public static List<TempBook> GetBooksWAuthor()
        {
            List<TempBook> booksWAuthors = new List<TempBook>();

            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var books = (from Böcker in context.Böckers
                              join Bokförlag in context.Bokförlags on Böcker.BokförlagNamn equals Bokförlag.Namn
                              join FörfattareBöcker in context.FörfattareBöckers on Böcker.Isbn equals FörfattareBöcker.Isbn
                              join Författare in context.Författares on FörfattareBöcker.FörfattareId equals Författare.Id
                              select new
                              {
                                  ISBN = Böcker.Isbn,
                                  Title = Böcker.Titel,
                                  Language = Böcker.Språk,
                                  Price = Böcker.Pris,
                                  ReleaseDay = Böcker.Utgivningsdatum,
                                  PublisherName = Bokförlag.Namn,
                                  PublisherCountry = Bokförlag.Land,
                                  AuthorFirstName = Författare.Förnamn,
                                  AuthorLastName = Författare.Efternamn,
                                  AuthorID = Författare.Id
                              }).ToList();

                
                

                foreach (var item in books)
                {
                    EFDtataAccessLibary.Models.Bokförlag pubL = new EFDtataAccessLibary.Models.Bokförlag();

                    pubL.Namn = item.PublisherName;
                    pubL.Land = item.PublisherCountry;

                    booksWAuthors.Add(new TempBook(
                        item.ISBN,
                        item.Title,
                        item.Language,
                        item.Price,
                        item.ReleaseDay,
                        pubL,
                        item.AuthorFirstName,
                        item.AuthorLastName,
                        item.AuthorID
                        ));
                }

                return booksWAuthors;
            }
        }
        public static List<EFDtataAccessLibary.Models.Bokförlag> GetPublishers()
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var publishList = context.Bokförlags.ToList();

                return publishList;
            }
        } 


        public static Boolean UpdateBook(TempBook book)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var books = context.Böckers.FirstOrDefault(a => a.Isbn == book.ISBN);
                var authorBooks = context.FörfattareBöckers.First(a => a.Isbn == book.ISBN);
                var authors = context.Författares.FirstOrDefault(a => a.Förnamn.Equals(book.AuthorFirstName));

                books.Isbn = book.ISBN;
                books.Titel = book.Title;
                books.Språk = book.Language;
                books.Pris = book.Price;
                books.Utgivningsdatum = book.ReleaseDay;
                books.BokförlagNamn = book.Publisher.Namn;

                authorBooks.FörfattareId = book.AuthorID;


                context.SaveChanges();

                return true;
            }
        }
        

    }
}
