using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDemidenko;


namespace ExamDemidenkoConsoleApp
{
    internal class Program
    {
        internal class Library : IComparable<Library>
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Count { get; set; }

            public Library(string mark, string number, int probeg)
            {
                Title = mark;
                Author = number;
                Count = probeg;
            }

            public override string ToString()
            {
                string s = $"Данные о книге: \n" +
                           $"- Название: {Title} \n" +
                           $"- Автор: {Author} \n" +
                           $"- Стоимость: {Count} Руб.";
                return s;
            }


            public int CompareTo(Library other)
            {
                if (this.Count > other.Count) return 1; // пробег текущего авто больше пробега переданного
                if (this.Count < other.Count) return -1; // пробег текущего авто меньше пробега переданного
                else return 0; // пробеги автомобилей равны 
            }
        }
        static void Main(string[] args)
        {
            User ps = new User("Иванов П.А.", "Администратор");
            ps.Show();
            Books b1 = new Books("Первая книга", "Пушкин", 500);
            ps.Library.Add(b1);
            Books b2 = new Books("Вторая книга", "Колотушкин", 140);
            ps.Library.Add(b2);
            Books b3 = new Books("Третья книга", "Кукушкин", 390);
            ps.Library.Add(b3);
            List<Library> col = new List<Library>();
            Console.WriteLine("Работа со стандартным интерфейсом");
            foreach (Books b in ps.Library)
            {
                b.Show();
                Library book1 = new Library(b.Title, b.Author, b.Count);
                col.Add(book1);
            }
            col.Sort();
            foreach (Library lib in col)
            {
                Console.WriteLine();
                Console.WriteLine(lib.ToString());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
