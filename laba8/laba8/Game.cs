using System;

public class Game
{
    public string Name { get; set; }
    public int Health { get; set; }
    public delegate void CritAttack(string message);
    public event CritAttack DoAttack;

    public Game(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(int health)
    {
        if (health != 0)
        {
            Health -= health;
        DoAttack?.Invoke(Name + "Вас ранили");
        }
        else
        {
            DoAttack?.Invoke(Name + "Ваше здоровье осталось прежним");
        }
    }
        public void Heal(int health)
    {
        if (health != 0)
        {
            Health += health;
            DoAttack?.Invoke(Name + "Вас вылечили");
        }
        else
        {
            DoAttack?.Invoke(Name + "Ваше здоровье осталось прежним");
        }
    }
   
    public void Display()
    {
        Console.WriteLine($"Name:" + Name + "\tHealth:" + Health);
    }




}
