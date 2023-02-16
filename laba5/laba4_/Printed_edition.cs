using System;
abstract public class Printed_edition : Publishing_house,IVoid
{
    
    public string Name { get; set; }
    public string Type { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }

    public Printed_edition(string name, string type, int year, int price)
    {
        Name = name;
        Type = type;
        Year = year;
        Price = price;
    }
    public override string Display()
    {
        return $"Название: {Name}, Тип: {Type}, Год издания: {Year}, Цена: {Price}";
    }
   
}