using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Вариант 6
 Класс - однонаправленный список List. Дополнительно
перегрузить следующие операции: >>  удалить элемент в
заданной позиции +  добавить элемент в заданную позицию,
например, !=  проверка на неравенство множеств.
Методы расширения:
1) Поиск самого длинного слова
2) Удаление последнего элемента из списка
*/
namespace laba_3

{
    
   public class _List:List<string>
    {
        public int PersonName { get; set; }
        public List<string> list = new List<string>();


        //МЕТОДЫ
        public void AddByIndex(int a, string b)
        {
            list.Insert(a, b);
        }
        public void AddBy(string PersonName )
        {
            list.Add(PersonName);
        }

        public void DeleteByIndex(int a)
        {
            list.RemoveAt(a);
        }

        public void ShowList()
        {
            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
        }

        //============= Перегрузка операторов =============

       public static _List operator +(_List list1, int index)
        {
            list1.AddByIndex(index,"Bob");
            return list1;
        }
        public static _List operator >>(_List list1, int index)
        {
            list1.DeleteByIndex(index);
            return list1;
        } 
        
        public static bool operator !=(_List list1, _List list2)
        {
            if (list1 != list2) return true;
            else return false;
        }
        public static bool operator ==(_List list1, _List list2)
        {
            if (list1 == list2) return true;
            else return false;
        }


        // ==================== ВЛОЖЕННЫЙ КЛАСС =======================
        public class Developer
        {
            public readonly int id;
            public string FCs;
            public string department;

            public Developer()
            {
                id = 1;
                FCs = " Иванов Иван Иванович";
                department = "Маркетинг";
            }


        }

    }
    //Статический класс
    static class StatisticOperation
    {
        //Поиск самой длинной строки
        public static string MaxLength(this _List list)
        {
            int maxSymbols = 0;
            string longestString = "";
            foreach (var item in list)
            {
                if (item.Length > maxSymbols)
                {
                    maxSymbols = item.Length;
                    longestString = item;
                }
            }
            return longestString;
        }
        //УДАЛЕНИЕ ПОСЛЕДНЕГО ЭЛЕМЕНТА СПИСКА
        public static void RemEnd(this _List list)
        {
            list.RemoveAt(list.Count - 1);
        }
        public static string MinLenght(this _List list)
        {
            int minSymbols = 0;
            string shortString = "";
            foreach (var item in list)
            {
                if (item.Length > minSymbols)
                {
                    minSymbols = item.Length;
                    shortString = item;
                }
            }
            return shortString;
        }
        //РАЗНОСТЬ СТРОК
        public static string Difference(this _List list)
        {
            string diff = MaxLength(list).Replace(MinLenght(list),"");
            return diff;
        }
        //Сумма
        public static string Sum(this _List list)
        {
            string sum = "";
            foreach (var item in list)
            {
                sum += (string)item;
            }
            return sum;
        }
        //КОЛИЧЕСТВО ЭЛЕМЕНТОВ
        public static int CountOfList(this _List list)
        {
            int count = list.Count;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лист 1:");
            _List list1 = new _List();
            list1.AddBy("dog");
            list1.AddBy("cat");
            list1.AddBy("girl");
            list1.ShowList();
            Console.WriteLine("------------  Перегрузка оператора >>  ------------");
            _List listp = list1 >> 2;
            listp.ShowList();

            Console.WriteLine("------------  Перегрузка оператора +  ------------");
            _List listp2 = list1 + 1;
            listp2.ShowList();

            Console.WriteLine("------------  Перегрузка оператора !=  ------------");
            bool listp3 = list1 == listp2;
            Console.WriteLine(listp3);


            Console.WriteLine("Лист 2:");
            _List list2 = new _List();
            list2.AddBy("cat");
            list2.ShowList();


            Console.WriteLine("List3");
            _List list3 = new _List();
            list3.AddBy("hello world");
            list3.AddBy("Bobbbbb");
            list3.AddBy("Mikeeee");
            list3.AddBy("world");


            Console.WriteLine("List4");
            _List list4 = new _List();
            list4.AddBy("labs");
            list4.AddBy("sun");
            list4.AddBy("monday");
            list4.AddBy("peter");


            Console.WriteLine("=============Методы расширения===========");
            Console.WriteLine("Самая длинная строка"+ list3.MaxLength());
            Console.WriteLine("Удаление последнего элемента");
            list4.ShowList();
            list4.RemEnd();
            list4.ShowList();
            Console.WriteLine("Сумма" + list1.Sum());
            Console.WriteLine("Разница" + list3.Difference());
            Console.WriteLine("Количество элементов" + list2.CountOfList());

            _List.Developer objDeveloper = new _List.Developer();

        }
    }
    

}
