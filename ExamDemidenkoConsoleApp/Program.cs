using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamDemidenko;


namespace ExamDemidenkoConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //show
            User ps = new User("Иванов П.А.", "Администратор");
            Console.WriteLine("Show:");
            ps.Show();
            Books b1 = new Books("Первая книга", "Пушкин");
            ps.Library.Add(b1);
            Books b2 = new Books("Вторая книга", "Пашкин");
            ps.Library.Add(b2);
            Books b3 = new Books("Третья книга", "Пгшкин");
            ps.Library.Add(b3);
            //showall
            Console.WriteLine();
            Console.WriteLine("ShowAll:");
            ps.ShowAll(ps);
            Console.WriteLine();
            List<Books> col = ps.newList(ps);
            col.Sort();
            //sort
            Console.WriteLine("Comparable:");
            foreach (Books lib in col)
            {
                Console.WriteLine(lib.ToString());
            }
            Console.ReadKey();
        }
    }
}
