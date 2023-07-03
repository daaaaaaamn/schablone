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
            User ps = new User("Иванов П.А.", 2004, "Москва");
            Console.WriteLine("Show:");
            ps.Show();
            Computers b1 = new Computers("Интел", 2000, 1667, 600);
            ps.Library.Add(b1);
            Computers b2 = new Computers("АМД", 1300, 354, 400);
            ps.Library.Add(b2);
            Computers b3 = new Computers("Зеон", 450, 999, 300);
            ps.Library.Add(b3);
            //showall
            Console.WriteLine();
            Console.WriteLine("ShowAll:");
            ps.ShowAll(ps);
            Console.WriteLine();
            List<Computers> col = ps.newList(ps);
            col.Sort();
            //sort
            Console.WriteLine("Comparable по возростанию объёма:");
            foreach (Computers lib in col)
            {
                Console.WriteLine(lib.ToString());
            }
            Console.ReadKey();
        }
    }
}
