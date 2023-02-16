using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laba5
{

    public static partial class PartClass
    {
        public static void Output()
        {
            Console.WriteLine("Моя библиотека");
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();

            try
            {
                Library library = new Library();
                Book book = new Book("Гарри Поттер и философский камень", "Фэнтези-книга", 1991, 49, 123);
                Magazine magazine = new Magazine("Times", "Журнал", 2021, 41, "Мягкая");
                library.Add(book);
                library.Add(magazine);
                library.Count();
                library.DisplayAll();
                library.Price();
                library.OldBook();
            }
            catch (MyException ex)
            {
                fileLogger.WriteLog(ex);
            }
            finally { }

            try
            {
                int x = 5, y = 0;
                x /= y;
            }
            catch (MyException ex)
            {
                fileLogger.WriteLog(ex);
            }
            finally { Console.WriteLine("Попытка деления на ноль не удалась");
            
            }

            try
            {
                int[] array = { 1, 2, 3 };
                Console.WriteLine(array[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Источник: " + ex.Source);
            }

           

            try
            {
                string str = "исключение";
                if (str == null)
                {
                    throw new ArgumentNullException("Было присвоено значение NULL ");
                }
                Console.WriteLine(str);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Источник: " + ex.Source);
            }

            try
            {
                Console.Write("Введите число типа byte: ");
                byte b = byte.Parse(Console.ReadLine());
                int[] myArr = new int[5] { 1, 2, 0, 10, 12 };
                Console.WriteLine("Исходный массив: ");

                for (int j = 0; j <= myArr.Length; j++)
                    Console.WriteLine("{0}\t", myArr[j]);

                int i = 120;
                Console.WriteLine("\nДелим на число: \n");
                foreach (int d in myArr)
                    Console.WriteLine(i / d);
            }

            catch (OverflowException)
            {
                Console.WriteLine("Данное число не входит в диапазон 0 - 255");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс выходит за пределы\n");
            }

            try
            {
                int[] array = new[] { 12, 10, 82 };
                int index = 100;
                if (array.Length < index)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(array[index]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Источник: " + ex.Source);

            }
            finally
            {
                Console.WriteLine("Неправильный индекс");
            }

           
                void Func()
                {
                try
                {
                    int x = 5, y = 0;
                    x /= y;
                }
                catch 
                {
                    throw;
                }
            }
           
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            void findsqrt(int Number)
            {
                Debug.Assert(Number == 0, "Нельзя извлечь корень из отрицательного");

                Console.WriteLine(Math.Sqrt(Number));
            }
            findsqrt(number);
        }
    }

    }
