using LibraryERP.DataBase.Abstracts;
using LibraryERP.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryERP.DataBase
{
    public class BookService : Servicable<BookModel>
    {


        public BookService(LibraryDbContext libraryDbContext) : base(libraryDbContext, libraryDbContext.Books)
        {

        }
    }
}
