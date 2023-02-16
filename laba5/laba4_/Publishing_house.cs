using System;
public abstract class Publishing_house
{
    public string Description { get; set; }

    public virtual string Display()
    {
        return Description;
    }
    public override string ToString()
    {
        return $"Издание";
    }
   
  
}
