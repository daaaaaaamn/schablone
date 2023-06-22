using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemidenko
{
    public class Person
    {
        // книги данного человека
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Library = new List<Book>();
        public Person(string nm, string ad)
        {
            Name = nm;
            Address = ad;
        }
        public void Show()
        {
            Console.WriteLine($"Человек: имя = {Name}, адрес = {Address}");
        }
    }
    //  класс книг
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string nm, string avt)
        {
            Title = nm;
            Author = avt;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Книга: название = {Title}, автор = {Author}");
        }
    }
}
