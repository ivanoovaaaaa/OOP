using System;
public sealed class Guide : Printed_edition, IVoid
{
    public int Countoftutors;
    public Guide(string Name, string Type, int Year, int Price, int countoftutors) : base(Name, Type, Year, Price)
    {
        Countoftutors = countoftutors;
    }
    public override string Display()
    {
        return $"Название: {Name}, Тип: {Type}, Год издания: {Year}, Цена: {Price}p, Кол-во издателей: {Countoftutors}";
    }
}