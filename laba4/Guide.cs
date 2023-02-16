using System;

sealed class Guide : PrintEdition, IVoid
{
    public override string ToString()
    {
        return $"Учебник";
    }
    public string topic;
    public Guide(string Name, int Year, string Binding, string Author, string Person, string Publishing, string topic) :
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
    void IVoid.Theme()
    {
        Console.WriteLine($"Тема: {topic}\n");
    }
    public override void Theme()
    {
        Console.WriteLine("Тема: { topic}\n");
    }