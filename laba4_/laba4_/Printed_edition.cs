using System;
abstract public class Printed_edition : Publishing_house
{
    public override void Company()
    {
        Console.WriteLine("Это ОЗ");
    }
    public override string ToString()
    {
        return $"Издание";
    }
    public string name;
    public int year;
    public string binding;
    public string author;
    public string person;
    public string publishing;
    public Printed_edition(string Name, int Year, string Binding, string Author, string Person, string Publishing)
    {
        this.Name = Name;
        this.Year = Year;
        this.Binding = Binding;
        author = Author;
        person = Person;
        publishing = Publishing;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public string Binding
    {
        get { return binding; }
        set { binding = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public string Person
    {
        get { return person; }
        set { person = value; }
    }
    public string Publishing
    {
        get { return publishing; }
        set { publishing = value; }
    }
    public override int GetHashCode()
    {
        Console.WriteLine($"Хэш-код издания {this.name} is: {name.GetHashCode()}");
        return name.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        Printed_edition Bookname = obj as Printed_edition;
        if (Bookname as Printed_edition == null)
        {
            return false;
        }
        return Bookname.name == this.name;
    }
    public void Print()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Год издания: {year}");
        Console.WriteLine($"Переплет: {binding}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Персона: {person}");
        Console.WriteLine($"Издательство: {publishing}");
    }
    public abstract void Theme();

}