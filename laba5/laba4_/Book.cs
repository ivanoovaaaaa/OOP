using System;
public class Book : Printed_edition, IVoid
{

 
    public int Countpages { get; set; }
    public Book(string Name, string Type, int Year, int Price, int countpages) : base(Name, Type, Year, Price)
    {
        Countpages = countpages;
    }
    public override string Display()
    {
        return $"Название: {Name}, Тип: {Type}, Год издания: {Year}, Цена: {Price}p, Кол-во страниц: {Countpages}";
    }

}