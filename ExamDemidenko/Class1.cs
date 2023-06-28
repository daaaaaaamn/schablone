using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemidenko
{
    public class User
    {
        // книги данного человека
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Books> Library = new List<Books>();
        public User(string nm, string ad)
        {
            Name = nm;
            Role = ad;
        }
        public void Show()
        {
            Console.WriteLine($"Человек: имя = {Name}, роль = {Role}");
        }
    }
    //  класс книг
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }
        public Books(string nm, string avt, int rub)
        {
            Title = nm;
            Author = avt;
            Count = rub;
        }
        public void Show()
        {
            Console.WriteLine($"Предмет: наименование = {Title}, количество = {Author}, Стоимость {Count}");
        }
    }

    
}
