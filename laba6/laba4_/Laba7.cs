using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
public class MyException : System.Exception
{
    public string ErrorClass { get; set; }
    public MyException(string message, string errorClass)
        : base(message)  // наследуем message от System.Exception
    {
        this.ErrorClass = errorClass;
    }
}
public class DateException : MyException
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public DateException(string message, int errorDay, int errorMonth, int errorYear)
        : base(message, "Error code 1: Uncorrect date.\n")  // наследуем message и errorClass от MyException
    {
        this.Day = errorDay;
        this.Month = errorMonth;
        this.Year = errorYear;
    }
}

public class TypeException : MyException
{
    public int Type { get; set; }
    public TypeException(string message, int errorType)
        : base(message, "Error code 2: Uncorrect type.\n")
    {
        this.Type = errorType;
    }
}

public class PriceException : MyException
{
    public int Price { get; set; }
    public PriceException(string message, int errorType)
        : base(message, "Error code 2: Uncorrect price.\n")
    {
        this.Price = errorType;
    }
}

public class SearchTypeException : MyException
{
    public int Type { get; set; }
    public SearchTypeException(string message, int errorType)
        : base(message, "Error code 3: Uncorrect type input for search.\n")
    {
        this.Type = errorType;
    }
}

public class NameException : MyException
{
    public string Name { get; set; }
    public NameException(string message, string errorName)
        : base(message, "Error code 4: Uncorrect name.\n")
    {
        this.Name = errorName;
    }
}
public class FileLogger
{
    public FileLogger() { }
    public void WriteLog(MyException exception)
    {
        DateException DateEx = exception as DateException;
        TypeException TypeEx = exception as TypeException;
        SearchTypeException SearchEx = exception as SearchTypeException;
        NameException NameEx = exception as NameException;

        string filePath = @"D:\3 sem\OOP\git_oop\OOP\laba6\log.txt";
        using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
        streamWriter.WriteLine(DateTime.Now);
        if (DateEx != null)
        {
            streamWriter.WriteLine("{0}{1} {2}.{3}.{4}", DateEx.ErrorClass, DateEx.Message, DateEx.Day, DateEx.Month, DateEx.Year); ;
        }
        if (TypeEx != null)
        {
            streamWriter.WriteLine("{0}{1} {2}", TypeEx.ErrorClass, TypeEx.Message, TypeEx.Type);
        }
        if (SearchEx != null)
        {
            streamWriter.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Type);
        }
        if (NameEx != null)
        {
            streamWriter.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
        }
    }
}
public class ConsoleLogger
{
    public ConsoleLogger() { }
    public void WriteLog(MyException exception)
    {
        DateException DateEx = exception as DateException;
        TypeException TypeEx = exception as TypeException;
        SearchTypeException SearchEx = exception as SearchTypeException;
        NameException NameEx = exception as NameException;

        Console.WriteLine("\n" + DateTime.Now);
        if (DateEx != null)
        {
            Console.WriteLine("{0}{1} {2}.{3}.{4}", DateEx.ErrorClass, DateEx.Message, DateEx.Day, DateEx.Month, DateEx.Year); ;
        }
        if (TypeEx != null)
        {
            Console.WriteLine("{0}{1} {2}", TypeEx.ErrorClass, TypeEx.Message, TypeEx.Type);
        }
        if (SearchEx != null)
        {
            Console.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Type);
        }
        if (NameEx != null)
        {
            Console.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
        }
    }
}

