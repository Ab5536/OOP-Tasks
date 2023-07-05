using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_task_2.BL
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> Chapters = new List<string>();
        public int bookMark;
        public int price;
       // public void setprice()
       public Book(string author,int pages,List<string> Chapters,int bookMark,int price)
        {
            this.author = author;
            this.pages = pages;
            this.Chapters = Chapters;
            this.bookMark = bookMark;
            this.price = price;
        }
        public string getChapter(int chapterNumber)
        {
            return Chapters[chapterNumber];
        }
        public int getBookMark()
        {
            return bookMark;
        }
        public void setBookmark(int pageNumber)
        {
            bookMark = pageNumber;
        }                
        public int getBookPrice()
        {
            return price;
        }
        public void setBookPrice(int newPrice)
        {
            price = newPrice;
        }
    }
}
