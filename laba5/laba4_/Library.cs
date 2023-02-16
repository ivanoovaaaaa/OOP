using System;
using System.Collections.Generic;

public class Library:List<Printed_edition>
{
    List<Printed_edition> MyLibrary = new List<Printed_edition>();
    public int tutorscount = 0;
    public int sum = 0;
    public void Push(Printed_edition item)
    {
        MyLibrary.Add(item);
        if (item.Type == "Учебник") tutorscount++;
        sum += item.Price;
    }

    public void Pop(int number)
    {
        MyLibrary.RemoveAt(number);
    }

    public void DisplayAll()
    {
        foreach (var item in MyLibrary)
        {
            Console.WriteLine(item.Display());
        }
    }
}

