using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Properties.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {

            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string authorName)
        {

            // return DataSource().Where(x => x.Title == title || x.Author.Contains(authorName)).ToList();
            
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();

        }

        //currently we are not working on data base so we are going to create a local data source
        private List<BookModel> DataSource()
            {
            return new List<BookModel>()
            {
            new BookModel() {Id =1, Title="MVC", Author= "Ali", description="THis is description for MVC book", Category="MVC", Language="English", ToatalPages=234},
            new BookModel() {Id =2, Title="C", Author= "Usama", description="THis is description for C book", Category="C", Language="Urdu", ToatalPages=134},
            new BookModel() {Id =3, Title="Java", Author= "Usama", description="THis is description for Java book", Category="Programming", Language="Spanish", ToatalPages=139 },
            new BookModel() {Id =4, Title="Algorithm", Author= "khan", description="THis is description for Algorithm book", Category="Programming", Language="Chines", ToatalPages=299 },
            new BookModel() {Id =5, Title="Android", Author= "Safi", description="THis is description for Android book", Category="Programming", Language="Udu", ToatalPages=334 },
            

            };

    }
}

}
