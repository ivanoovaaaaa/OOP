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
    class Program
    {
        static void Main(string[] args)
        {
                //Создание объектов
                Computer<object> Apple = new Computer<object>("Apple", 2010);
                Computer<object> HP = new Computer<object>("HP", 2019);
                Computer<object> Asus = new Computer<object>("Asus", 2015);
                Computer<object> Lenovo = new Computer<object>("Lenovo", 2000);

                HashSet<object> HashSetCollection = new HashSet<object>();
                HashSetCollection.Add(Apple);
                HashSetCollection.Add(HP);
                HashSetCollection.Add(Asus);
                HashSetCollection.Add(Lenovo);
                ShowCollection(HashSetCollection);
                Console.ReadKey();

                UniversalCollection.UHSC.Add('h');
                UniversalCollection.UHSC.Add('e');
                UniversalCollection.UHSC.Add('l');
                UniversalCollection.UHSC.Add('L');
                UniversalCollection.UHSC.Add('o');

                List<char> UniversalCollection2 = new List<char>();
                foreach (char symbol in UniversalCollection.UHSC)
                {
                    UniversalCollection2.Add(symbol);
                }

                UniversalCollection.Display();
                UniversalCollection.DeleteElements('h');
                UniversalCollection.Display();
                Console.ReadKey();

                foreach (char symbol in UniversalCollection2)
                {
                    Console.Write(symbol);
                }
                Console.ReadKey();

                ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User {Name = "Denis"},
                new User {Name = "Stas"},
                new User {Name = "Pasha"}

            };

                users.CollectionChanged += Users_CollectionChanged;

                users.Add(new User { Name = "Olga" });
                users.RemoveAt(1);

                Console.ReadKey();

            }

            static void ShowCollection(HashSet<object> computers)
            {
                foreach (object str in computers)
                {
                    Console.WriteLine(str.ToString() + "\n");
                }
            }

            private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        User newUser = e.NewItems[0] as User;
                        Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        User oldUser = e.OldItems[0] as User;
                        Console.WriteLine($"Удален объект: {oldUser.Name}");
                        break;
                }
            }
            }
    }

