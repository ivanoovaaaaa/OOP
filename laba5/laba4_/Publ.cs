using System;
   public class Publ
    {
    public enum Genre
    {

        Fantasy,
        Drama,
        Romance,
        Thriller,
        Action,
        Detectives,
        Science,
        History,
        Medicine,
        Crime
    }
    public struct Reader
    {
        public string name;
        public int age;
        public Reader(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя читателя: {name}  Возраст: {age}");
        }
    }
    }

