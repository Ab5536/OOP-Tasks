using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_4_task_2.BL;

namespace Lab_4_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            int option;
            do
            {
                option = Menu();
                if (option == 1)
                {
                    Console.Clear();
                    books.Add(inputNewBook());
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Book b = checkBook(books);
                    int no = b.Chapters.Count;
                    int chapterNumber = chapnumber(no);
                    Console.WriteLine("Chapter Name: {0}", b.getChapter(chapterNumber));
                }
                else if (option == 3)
                {
                    Book b = checkBook(books);
                    Console.WriteLine("Book Mark Page: " + b.getBookMark());
                }
                else if (option == 4)
                {
                    Book b = checkBook(books);
                    Console.Write("Enter the page number of Book Mark: ");
                    int pageNumber = int.Parse(Console.ReadLine());
                    b.setBookmark(pageNumber);
                }
                else if (option == 5)
                {
                    Book b = checkBook(books);
                    Console.WriteLine("Price of Book: " + b.getBookPrice());
                }
                else if (option == 6)
                {
                    Book b = checkBook(books);
                    Console.Write("Enter the price of Book : ");
                    int newPrice = int.Parse(Console.ReadLine());
                    b.setBookPrice(newPrice);
                }
                else if (option == 7)
                {
                    break;
                }
            } while (option!=7);
        }

        public static Book inputNewBook()
        {
            Console.Write("Enter Author of Book: ");
            string author = Console.ReadLine();
            Console.Write("Enter pages of Book: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Enter bookMark page number: ");
            int bookMark = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Book: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter number of Chapters: ");
            int number = int.Parse(Console.ReadLine());
            List<string> Chapters = new List<string>();
            for (int x = 0; x < number; x++)
            {
                Console.WriteLine("Enter chapter {0}: ", x + 1);
                string chap= Console.ReadLine();
                Chapters.Add(chap);

            }
            Book b = new Book(author, pages, Chapters, bookMark, price);
            return b;
        }

        public static int Menu()
        {
            Console.WriteLine("1. Enter information about Book: ");
            Console.WriteLine("2. Get Chapter: ");
            Console.WriteLine("3. Get BookMark: ");
            Console.WriteLine("4. Set BookMark: ");
            Console.WriteLine("5. Get Book Price: ");
            Console.WriteLine("6. Set Book Price: ");
            Console.WriteLine("7. Exit ");
            Console.Write("Your Choice: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Book checkBook(List<Book> books)
        {
            Console.Write("Enter author of Book: ");
            string bk = Console.ReadLine();
           // for (int i = 0; i < books.Count; i++){
           foreach(Book b in books)
            {
                if (b.author == bk)
                {
                    return b;
                }
            }
            return null;
            
        }
        public static int chapnumber(int no)
        {
            while (true)
            {

            Console.Write("Enter Chapter Number: ");
            int chapterNumber = int.Parse(Console.ReadLine());
                if (chapterNumber <= no + 1)
                {
                    return chapterNumber-1;
                }
                Console.WriteLine("Enter chapter number < {0} ",no+1);
            }
        } 
    }
}