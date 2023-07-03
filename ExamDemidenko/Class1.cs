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
        public string Address { get; set; }
        public List<Books> Library = new List<Books>();
        public User(string username, string userrole)
        {
            Name = username;
            Address = userrole;
        }
        public void Show()
        {
            Console.WriteLine($"Человек: имя = {Name}, роль = {Address}");
        }
        public List<Books> newList(User user)
        {
            List<Books> col = new List<Books>();
            foreach (Books b in user.Library)
            {
                Books book1 = new Books(b.Title, b.Author);
                col.Add(book1);
            }
            return col;
        }
        public void ShowAll(User ps)
        {
            ps.Show();
            foreach (Books b in ps.Library)
            {
                b.Show();
            }
        }


    }
    //  класс книг
    public class Books : IComparable<Books>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Books(string bookname, string bookavtor)
        {
            Title = bookname;
            Author = bookavtor;
        }
        public override string ToString()
        {
            string s = $"Данные о книге: \n" +
                       $"- Название: {Title} \n" +
                       $"- Автор: {Author}";
            return s;
        }
        public int CompareTo(Books other)
        {
            int result = String.Compare(this.Author, other.Author);
            if (result < 0)
            {
                return -1;
            }
            else if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Предмет: наименование = {Title}, количество = {Author}");
        }
    }

    
}
