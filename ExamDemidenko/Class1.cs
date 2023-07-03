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
        public string FIO { get; set; }
        public int DATA { get; set; }
        public string ADRESS { get; set; }
        public List<Computers> Library = new List<Computers>();
        public User(string fio, int date, string adress)
        {
            FIO = fio;
            DATA = date;
            ADRESS = adress;

        }
        public void Show()
        {
            Console.WriteLine($"Человек: Marka = {FIO}, God = {DATA}, Speed = {ADRESS}");
        }
        public List<Computers> newList(User user)
        {
            List<Computers> col = new List<Computers>();
            foreach (Computers b in user.Library)
            {
                Computers book1 = new Computers(b.Marka, b.God, b.Speed, b.Value);
                col.Add(book1);
            }
            return col;
        }
        public void ShowAll(User ps)
        {
            ps.Show();
            foreach (Computers b in ps.Library)
            {
                b.Show();
            }
        }


    }
    //  класс книг
    public class Computers : IComparable<Computers>
    {
        public string Marka { get; set; }
        public int God { get; set; }
        public int Speed { get; set; }
        public int Value { get; set; }
        public Computers(string marka, int god, int speed, int value)
        {
            Marka = marka;
            God = god;
            Speed = speed;
            Value = value;

        }
        public override string ToString()
        {
            string s = $"Данные о компьютере: \n" +
                       $"- Марка: {Marka} \n" + 
                       $"- Год: {God} \n" + 
                       $"- Скорость: {Speed} \n" +
                       $"- Объем: {Value}";
            return s;
        }
        public int CompareTo(Computers other)
        {
            if (this.Value < other.Value)
            {
                return -1;
            }
            else if (this.Value > other.Value)
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
            Console.WriteLine($"Компьютер: Марка: {Marka}, Год: {God}, Скорость: {Speed}, Объем: {Value}");
        }
    }

    
}
