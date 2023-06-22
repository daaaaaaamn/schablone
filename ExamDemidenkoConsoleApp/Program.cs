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
        static void Main(string[] args)
        {
            Person ps = new Person("Иванов П.А.", "г. Москва");
            ps.Show();
            Book b1 = new Book("Сказки", "Пушкин А.С.");
            ps.Library.Add(b1);
            Book b2 = new Book("Язык C#", "Григорьев В.С.");
            ps.Library.Add(b2);
            foreach (Book b in ps.Library)
            {
                b.Show();
            }
            Console.ReadKey();
        }
    }

}
