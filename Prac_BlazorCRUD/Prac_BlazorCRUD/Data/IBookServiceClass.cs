using Prac_BlazorCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prac_BlazorCRUD.Data
{
    public interface IBookServiceClass
    {
        Task<IEnumerable<Book>> GeatAllBook();
        Task<Book> GetBookDetails(int id);

        Task<bool> InsertBook(Book book);
        Task<bool> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<bool> SaveBook(Book book);



    }
}
