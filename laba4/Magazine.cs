using System;

sealed class Magazine : PrintEdition, IVoid
{
    public override string ToString()
    {
        return $"Журнал";
    }
    public string topic;
    public Magazine(string Name, int Year, string Binding, string Author, string Person, string Publishing, string topic) :
        base(Name, Year, Binding, Author, Person, Publishing)
    {
        this.Name = Name;
        this.Year = Year;
        this.Binding = Binding;
        author = Author;
        person = Person;
        publishing = Publishing;
        this.topic = topic;
    }
    public string Topic
    {
        get { return topic; }
        set { topic = value; }
    }
    public override void Theme()
    {
        Console.WriteLine("Тема: { topic}\n");
    }
}
