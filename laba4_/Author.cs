using System;

public class MyAuthor : Person
{

    public MyAuthor(string NamePers, string LastnamePers, string Post)
        : base(NamePers, LastnamePers, Post)
    {
        namePers = NamePers;
        lastnamePers = LastnamePers;
        post = Post;
    }

    public override string ToString()
    {
        return "\nИмя: " + NamePers + "\nФамилия: " + LastnamePers + "\n" + new String('-', 50);
    }