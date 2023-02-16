using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Журнал, Книга, Печатное издание, Учебник, Журнал, Персона,Автор, Издательство.

namespace laba4
{
    public interface IName
    {
        string Name { get { return Name; } set { this.Name = value; } }
    }
    public class PrintEdition
    {
        public int Сirculation { get; set; }
        public int YearOfRelease { get; set; }
    }
    public abstract class Person : IName
    {
        public string Name { get; set; }
    }
    public class Publisher
    {

    }

    public class Magazine:PrintEdition
    {
        public string Name { get; set; }

        public Magazine(string name, int release)
        {
            this.Сirculation = 1800;
            this.Name = name;
            this.YearOfRelease = release;
        }
        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nНазвание печатного издания: " + Name + "\nГод выпуска: " + YearOfRelease + "\nТираж: " + Сirculation + "\n" + new String('-', 50);
        }
    }


    public class Book : PrintEdition
    {
        public string Name { get; set; }
        public Book(string name, int release)
        {
            this.Сirculation = 600;
            this.Name = name;
            this.YearOfRelease = release;
        }
        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nНазвание печатного издания: " + Name + "\nГод выпуска: " + YearOfRelease + "\nТираж: " + Сirculation + "\n" + new String('-', 50);
        }
    }

    public class Textbook : PrintEdition
    {
        public string Name { get; set; }
        public Textbook(string name, int release)
        {
            this.Сirculation = 500000;
            this.Name = name;
            this.YearOfRelease = release;
        }

        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nНазвание печатного издания: " + Name + "\nГод выпуска: " + YearOfRelease + "\nТираж: " + Сirculation + "\n" + new String('-', 50);
        }
    }

    public class Author : Person
    {
        public string LastName { get; set; }

        public Author(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nИмя: " + Name + "\nФамилия: " + LastName + "\n" + new String('-', 50);
        }
    }



































    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Петя", "huesos");
        }
    }
}
