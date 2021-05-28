using BookStore.Models;
using BookStore.Properties.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Properties.Controllers
{
    public class BookController : Controller
    {
        //    public IActionResult Index()
        //    {                                     //default index
        //        return View();
        //    }

        private readonly BookRepository _bookRepository = null;
        private object _BookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();

        }

        //public List<BookModel> GetallBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}
        public ViewResult GetallBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        //public BookModel GetBook(int id)
       // {

         //   return _bookRepository.GetBookById(id);
            
    //}
    public ViewResult GetBook(int id)
        {

            dynamic data = new System.Dynamic.ExpandoObject();
            data.book = _bookRepository.GetBookById(id);
            data.Name = "Usama"; //dynamic data passing
            //var data =  _bookRepository.GetBookById(id);
            return View(data);
        }
        //query for search books by id and Namehttps://localhost:44337/book/searchbooks?bookName=mvc&authorName=Usama
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook()
        {

            return View();
        }

         
        [HttpPost] // use for handle post request
        public ViewResult AddNewBook(BookModel bookModel)
        {

            return View();
        }



        //public string GetALLBooks()
        //     {
        //         return "All Book";
        //     }

        //public string GetBook(int id)
        //{
        //    return $"book with id = {id}";
        //}

        //  public string SearchBooks(string bookName, string authorName) //how pass parameter in controler action method herehttps://localhost:44337/book/searchbooks?bookName=Quran&authorName=ALLAH
        //{
        //    return $"Book with name = {bookName} & authorName = { authorName}";

        //}
    }
}
