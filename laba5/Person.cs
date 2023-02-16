using System;


public class Person : Publishing_house
{
    public override string ToString()
    {
        return $"Персона";
    }

    public string namePers;
    public string lastnamePers;
    public string post;

    public Person(string NamePers, string LastnamePers, string Post)
    {
        this.NamePers = NamePers;
        this.LastnamePers = LastnamePers;
        this.Post = Post;

    }

    public string NamePers
    {
        get { return namePers; }
        set { namePers = value; }
    }
    public string LastnamePers
    {
        get { return lastnamePers; }
        set { lastnamePers = value; }
    }
    public string Post
    {
        get { return post; }
        set { post = value; }
    }
    public override void Company()
    {
        Console.WriteLine("Это ОЗ");
    }
}