using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Magazine magazine = new Magazine("Незнайка", 2020, "мягкий", "Носов Н.Н.", "СШ№1", "БелАсвета", "образование");
                Console.WriteLine($"Журнал");
                magazine.Print();
                magazine.Theme();
                ((IVoid)magazine).Theme();

                Book book = new Book("Хроники Шаннары", 1982, "твердый", "Терри Брукс", "книжный магазин", "Эксмо", "фантастика");
                Console.WriteLine($"Книга");
                book.Print();
                book.Theme();
                ((IVoid)book).Theme();

            Printed_edition guide = new Guide("Искусство любить", 2016, "твердый", "Эрих Фромм", "ОЗ", "Эксмо", "психология");
                Console.WriteLine($"Учебник");
                Guide guide1 = guide as Guide;
                if (guide1 != null)
                {
                    Console.WriteLine(guide1.Author);
                }
                ((IVoid)guide).Theme();
                guide.Theme();

                Printed_edition newbook = new Book("В поисках приключений", 1991, "твердый", "Терри Брукс", "OZ", "Evers", "художественная литература");
                if (newbook is Book newbook2)
                {
                    Console.WriteLine(newbook2.Name);
                }

                Printer print = new Printer();
                print.IamPrinting(magazine);
                print.IamPrinting(book);
                print.IamPrinting(guide);
            }
        }
    }
