using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            void DisplayMessage(string message) => Console.WriteLine(message);
            Game human = new Game("human", 100);
            human.DoAttack += DisplayMessage;
            human.Heal(20);
            human.Display();

            Game robot = new Game("robot", 100);
            robot.DoAttack += DisplayMessage;
            robot.Attack(50);
            robot.Display();

            Game dwarf = new Game("dwarf", 10);
            dwarf.DoAttack += DisplayMessage;
            dwarf.Heal(0);
            dwarf.Display();

            Game elf = new Game("elf", 80);
            elf.DoAttack += DisplayMessage;
            elf.Attack(70);
            elf.Display();

            Game org = new Game("org", 10);
            org.DoAttack += DisplayMessage;
            org.Heal(50);
            org.Display();

            Console.WriteLine("Обработка методов строк");
            Func<string, string> funcStr;
            string str = "B  . e!  ,  b,    ,r  .  a";

            Console.WriteLine($"Исходная строка:        {str}");
            funcStr = StringHandler.RemoveS;
            Console.WriteLine($"Без знаков препинания:  {str = funcStr(str)}");
            funcStr = StringHandler.RemoveSpase;
            Console.WriteLine($"Без пробелов:           {str = funcStr(str)}");
            funcStr = StringHandler.Upper;
            Console.WriteLine($"Заглавными буквами:     {str = funcStr(str)}");
            funcStr = StringHandler.Lower;
            Console.WriteLine($"Строчными буквами:      {str = funcStr(str)}");
            funcStr = StringHandler.AddToString;
            Console.WriteLine($"С добавлением символа:  {str = funcStr(str)}");
        }

    }
    }

