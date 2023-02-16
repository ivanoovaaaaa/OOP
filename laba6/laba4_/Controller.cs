using System;

public static class Controller
{
    public static void Count(this Library library)
    {
        Console.WriteLine("Количество учебников: " + library.tutorscount);
    }
    public static void Price(this Library library)
    {
  
        if (library.sum > 1000)
        {
            throw new PriceException("Неверная цена",library.sum);
        }
        Console.WriteLine("Цена всех изданий в библиотеке: " + library.sum);
    }

    public static void OldBook(this Library MyLibrary)
    {
        Console.Write("Введите год для книг, вышедших до него: ");
        int YearOfBook = Convert.ToInt32(Console.ReadLine());
        foreach (var books in MyLibrary)
        {
            if (books.Year < YearOfBook && books.Type == "Учебник")
            {
                Console.WriteLine(books.Name);
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
        }

    }
}

