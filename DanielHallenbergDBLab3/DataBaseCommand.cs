using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielHallenbergDBLab3
{
    public class DataBaseCommand
    {
        //Hämta listor
        public static List<EFDtataAccessLibary.Models.Butiker> GetStores()
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
        public static List<EFDtataAccessLibary.Models.Författare> GetAuthors()
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var författList = context.Författares.ToList();
                författList.Add(new EFDtataAccessLibary.Models.Författare("---Choose Author---"));

                return författList;
            }
        }
        public static List<TempBook> GetBooksWAuthor()
        {
            List<TempBook> booksWAuthors = new List<TempBook>();

            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var books = (from Böcker in context.Böckers
                             join Bokförlag in context.Bokförlags on Böcker.BokförlagNamn equals Bokförlag.Namn
                             select new
                             {
                                 ISBN = Böcker.Isbn,
                                 Title = Böcker.Titel,
                                 Language = Böcker.Språk,
                                 Price = Böcker.Pris,
                                 ReleaseDay = Böcker.Utgivningsdatum,
                                 PublisherName = Bokförlag.Namn,
                                 PublisherCountry = Bokförlag.Land
                             }).ToList();

                var authorsBooks = (from FörfattareBöcker in context.FörfattareBöckers
                                    select new
                                    {
                                        ISBN = FörfattareBöcker.Isbn,
                                        AuthorID = FörfattareBöcker.FörfattareId
                                    }).ToList();

                var authors = (from Författare in context.Författares
                               select new
                               {
                                   ID = Författare.Id,
                                   FirstName = Författare.Förnamn,
                                   LastName = Författare.Efternamn,
                                   Birthday = Författare.Födelsedatum
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
                        pubL
                        ));
                }

                for (int i = 0; i < booksWAuthors.Count; i++)
                {
                    for (int j = 0; j < authorsBooks.Count; j++)
                    {
                        if (booksWAuthors[i].ISBN == authorsBooks[j].ISBN)
                        {
                            if(context.Författares.Any(a => a.Id == authorsBooks[j].AuthorID))
                            {
                                var auth = context.Författares.FirstOrDefault(a => a.Id == authorsBooks[j].AuthorID) as EFDtataAccessLibary.Models.Författare;

                                booksWAuthors[i].Authors.Add(auth);
                            }
                            
                        }
                    }
                }

                for (int i = 0; i < booksWAuthors.Count - 1; i++)
                {
                    for (int j = i + 1; j < booksWAuthors.Count; j++)
                    {
                        if (booksWAuthors[i].ISBN == booksWAuthors[j].ISBN)
                        {
                            booksWAuthors.RemoveAt(i);
                            i = -1;
                            break;
                        }
                    }
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

        //Updatera listor
        public static Boolean UpdateSaldo(int ammount, long isbn, int storeNr)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var saldo = context.LagerSaldos.FirstOrDefault(a => a.Isbn == isbn && a.ButiksId == storeNr);

                if (saldo != null)
                {
                    saldo.Antal = saldo.Antal + ammount;

                    if (saldo.Antal >= 0)
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
        public static Boolean UpdateBook(TempBook book) 
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            { 
                var books = context.Böckers.FirstOrDefault(a => a.Isbn == book.ISBN);
                var authorsWBooks = context.FörfattareBöckers.ToList();

                books.Isbn = book.ISBN;
                books.Titel = book.Title;
                books.Språk = book.Language;
                books.Pris = book.Price;
                books.Utgivningsdatum = book.ReleaseDay;
                books.BokförlagNamn = book.Publisher.Namn;

                authorsWBooks[0].FörfattareId = book.NewAuthors[0].Id;

                if (book.NewAuthors.Count == 1 && book.Authors.Count > 1)
                {
                    var author = authorsWBooks.First(a => a.FörfattareId == book.Authors[1].Id);
                    context.FörfattareBöckers.Remove(author);

                    if(book.Authors.Count == 3)
                    {
                        var author2 = authorsWBooks.First(a => a.FörfattareId == book.Authors[2].Id);
                        context.FörfattareBöckers.Remove(author2);
                    }
                }

                if (book.NewAuthors.Count >= 2)
                {
                    if (book.Authors.Count >= 2 && authorsWBooks[1].Isbn == book.ISBN)
                    {
                        authorsWBooks[1].FörfattareId = book.NewAuthors[1].Id;

                        if (book.Authors.Count > 2 && book.NewAuthors.Count > 2)
                        {
                            var author = authorsWBooks.First(a => a.FörfattareId == book.Authors[2].Id);
                            context.FörfattareBöckers.Remove(author);
                        }
                    }
                    else
                    {
                        EFDtataAccessLibary.Models.FörfattareBöcker fb = new EFDtataAccessLibary.Models.FörfattareBöcker();
                        fb.Isbn = book.ISBN;
                        fb.FörfattareId = book.NewAuthors[1].Id;

                        context.FörfattareBöckers.Add(fb);
                    }

                    if (book.NewAuthors.Count == 3)
                    {

                        if (book.Authors.Count >= 3 && authorsWBooks[2].Isbn == book.ISBN)
                        {
                            authorsWBooks[2].FörfattareId = book.NewAuthors[2].Id;
                        }
                        else
                        {
                            EFDtataAccessLibary.Models.FörfattareBöcker fb = new EFDtataAccessLibary.Models.FörfattareBöcker();
                            fb.Isbn = book.ISBN;
                            fb.FörfattareId = book.NewAuthors[2].Id;

                            context.FörfattareBöckers.Add(fb);
                        }
                    }
                }

                context.SaveChanges();

                return true;
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

        //Skapa
        public static Boolean AddAuthor(EFDtataAccessLibary.Models.Författare author)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var authors = context.Författares.ToList();

                for (int i = 0; i < authors.Count; i++)
                {
                    if (authors[i].Förnamn.Equals(author.Förnamn) && authors[i].Efternamn.Equals(author.Efternamn))
                    {
                        return false;
                    }
                }

                context.Författares.Add(author);
                context.SaveChanges();
                return true;
            }
        }
        public static Boolean AddBook(TempBook book)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                int stores = context.Butikers.Count();
                var books = context.Böckers.ToList();
                var booksAuthors = context.FörfattareBöckers.ToList();
                var quantitys = context.LagerSaldos.ToList();
                EFDtataAccessLibary.Models.Böcker bookToAdd = new EFDtataAccessLibary.Models.Böcker();

                EFDtataAccessLibary.Models.LagerSaldo quantityToAdd = new EFDtataAccessLibary.Models.LagerSaldo();

                for (int i = 0; i < books.Count; i++)
                {
                    if (book.ISBN == books[i].Isbn)
                    {
                        return false;
                    }
                }

                bookToAdd.Isbn = book.ISBN;
                bookToAdd.Titel = book.Title;
                bookToAdd.Språk = book.Language;
                bookToAdd.Pris = book.Price;
                bookToAdd.Utgivningsdatum = book.ReleaseDay;
                bookToAdd.BokförlagNamn = book.Publisher.Namn;
                context.Böckers.Add(bookToAdd);

                for (int i = 0; i < book.NewAuthors.Count; i++)
                {
                    EFDtataAccessLibary.Models.FörfattareBöcker booksAuthorsToAdd = new EFDtataAccessLibary.Models.FörfattareBöcker();
                    booksAuthorsToAdd.Isbn = book.ISBN;
                    booksAuthorsToAdd.FörfattareId = book.NewAuthors[i].Id;
                    context.FörfattareBöckers.Add(booksAuthorsToAdd);
                    context.SaveChanges();
                }

                for (int i = 0; i < stores; i++)
                {
                    quantityToAdd.Antal = 0;
                    quantityToAdd.Isbn = book.ISBN;
                    quantityToAdd.ButiksId = i + 1;

                    context.LagerSaldos.Add(quantityToAdd);
                    context.SaveChanges();
                }

                context.SaveChanges();

                return true;
            }
        }

        //Ta bort
        public static Boolean DeleteAuthor(int id)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var author = context.Författares.FirstOrDefault(a => a.Id == id);
                context.Remove(author);
                context.SaveChanges();
                return true;
            }
        }
        public static Boolean DeleteBook(TempBook book)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var books = context.Böckers.First(a => a.Isbn == book.ISBN);
                

                while(context.FörfattareBöckers.Any(a => a.Isbn == book.ISBN))
                {                   
                    var authorBook = context.FörfattareBöckers.First(a => a.Isbn == book.ISBN);
                    
                    context.Remove(authorBook);
                    context.SaveChanges();
                }

                while(context.LagerSaldos.Any(b => b.Isbn == book.ISBN))
                {
                    var quantity = context.LagerSaldos.First(a => a.Isbn == book.ISBN);
                    context.Remove(quantity);
                    context.SaveChanges();
                }

                context.Remove(books);
                context.SaveChanges();

                return true;

            }
        }

        //Special
        public static EFDtataAccessLibary.Models.Författare ShowAuthor(int id)
        {
            using (var context = new EFDtataAccessLibary.DataAccess.GewertsContext())
            {
                var author = context.Författares.FirstOrDefault(a => a.Id == id);

                return author;
            }
        }

    }
}
