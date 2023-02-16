using System;
public sealed class Magazine : Printed_edition, IVoid
{
    public string Cover { get; set; }
    public Magazine(string Name, string Type, int Year, int Price, string cover) : base(Name, Type, Year, Price)
    {
        Cover = cover;
    }
    public override string Display()
    {
        return $"Название: {Name}, Тип: {Type}, Год издания: {Year}, Цена: {Price}p, Обложка: {Cover}";
    }
}