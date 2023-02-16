using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{

    public static partial class PartClass
    {
        public static void Output()
        {
            Console.WriteLine("Моя библиотека");
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
            Book book = new Book("Гарри Поттер и философский камень", "Фэнтези-книга", 1991, 49, 123);
            Guide guide = new Guide("Психология поведения детей дошкольного возраста", "Учебник", 2019, 23, 1);
            Magazine magazine = new Magazine("Times", "Журнал", 2021, 41, "Мягкая");


            Publ.Genre  Action = Publ.Genre.Action;
            Console.WriteLine(Action);
            Console.WriteLine((int)Action);

            Publ.Reader reader1 = new Publ.Reader("София", 18);
            reader1.DisplayInfo();

            PartClass.Output();
           

            Library library = new Library();
            library.Push(book);
            library.Push(guide);
            library.Push(magazine);
            library.DisplayAll();
            library.Count();
            library.Price();
        }
        }
    }
