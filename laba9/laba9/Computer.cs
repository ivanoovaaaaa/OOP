using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;

namespace laba9
{
    class Computer<T> : ISet<T>
    {
        public string ComputerName { get; set; }
        public int Year { get; set; }

        public Computer(string computername, int year)
        {
            ComputerName = computername;
            Year = year;
        }

        public void Expluatation()
        {
            Console.WriteLine("Компьютеру " + ComputerName + " осталось жить " + (Year - 2021 + 30) + " лет");
        }

        public void Display()
        {
            Console.WriteLine("Компьютер: " + ComputerName + "\nГод производства: " + Year);
        }
        public override string ToString()
        {
            return "Компьютер: " + ComputerName + "\nГод производства: " + Year;
        }

        public int Count => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
        public bool Add(T a)
        {
            return true;
        }
        public void Clear()
        {

        }
        public bool Contains(T a)
        {
            return true;
        }
        public void UnionWith(T a)
        {

        }
        public void ExceptWith(IEnumerable<T> a)
        {

        }
        public void UnionWith(IEnumerable<T> a)
        {

        }
        public void IntersectWith(IEnumerable<T> a)
        {

        }
        public void SymmetricExceptWith(IEnumerable<T> a)
        {

        }
        public bool IsSubsetOf(IEnumerable<T> a)
        {
            return true;
        }
        public bool IsSupersetOf(IEnumerable<T> a)
        {
            return true;
        }
        public bool IsProperSupersetOf(IEnumerable<T> a)
        {
            return true;
        }
        public bool IsProperSubsetOf(IEnumerable<T> a)
        {
            return true;
        }
        public bool Overlaps(IEnumerable<T> a)
        {
            return true;
        }
        public bool SetEquals(IEnumerable<T> a)
        {
            return true;
        }
        public void CopyTo(T[] a, int b)
        {

        }
        public bool Remove(T a)
        {
            return true;
        }
        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public static class UniversalCollection
    {
        public static HashSet<char> UHSC = new HashSet<char>();

        public static void Display()
        {
            foreach (char symbol in UHSC)
            {
                Console.Write(symbol);
            }
        }
        public static void DeleteElements(char n)
        {
            Console.WriteLine("\n");
            UHSC.Remove(n);
        }
    }

    class User
    {
        public string Name { get; set; }
    }

}
