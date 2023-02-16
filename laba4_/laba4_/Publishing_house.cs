using System;
public abstract class Publishing_house
{
    Library library;
        public Publishing_house()
    {
        library = new Library();
    }
    public override string ToString()
    {
        return $"Издание";
    }
    public abstract void Company();
  
}
