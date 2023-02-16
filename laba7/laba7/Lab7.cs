using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CollectionType<T> : IActions<T> where T : class
{
    List<T> MyBook = new List<T>();

    public static T number;
    public void Add(T bookname)
    {
        MyBook.Add(bookname);
    }
    public void Delete(T number)
    {
        MyBook.Remove(number);
    }
    public void Display()
    {
        foreach (T elem in MyBook)
        {
            Console.WriteLine(elem);
        }

    }

    public void WriteToFile()
    {
        StreamWriter sw = new StreamWriter("D:\\3 sem\\OOP\\git_oop\\OOP\\laba7\\test.txt");
        foreach (T elem in MyBook)
        {
            sw.WriteLine(elem);
        }
        sw.Close();
    }
    public void ReadFromFile()
    {
        string line;
        StreamReader sr = new StreamReader("D:\\3 sem\\OOP\\git_oop\\OOP\\laba7\\test.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }
}
  