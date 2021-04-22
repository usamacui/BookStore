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

   public string GetALLBooks()
        {
            return "All Book";
        }

        public string GetBook(int id)
        {
            return $"book with id = {id}";
        }
    
        public string SearchBooks(string bookName, string authorName) //how pass parameter in controler action method herehttps://localhost:44337/book/searchbooks?bookName=Quran&authorName=ALLAH
        {
            return $"Book with name = {bookName} & authorName = { authorName}";

        }
    }
}
