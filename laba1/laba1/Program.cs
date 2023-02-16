using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Console.WriteLine(Task1 a)
      
            bool bool1 = true;
            Console.WriteLine("Bool1 =" + bool1); ;
            Console.WriteLine("Bool2 =");
            bool bool2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("bool2= " + bool2);

            byte bit1 = 1;
            Console.WriteLine("bit2 =");
            byte bit2 = Convert.ToByte(Console.ReadLine()); ;
            Console.WriteLine("bit2= " + bit2);

            sbyte sbit1 = -101;
            Console.WriteLine("sbit2 =");
            sbyte sbit2 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbit2= " + sbit2);

            short n1 = 102;
            Console.WriteLine("n2 =");
            short n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("n2= " + n2);

            ushort un1 = 120;
            Console.WriteLine("un2 =");
            ushort un2 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("un2= " + un2);

            int int1 = 8;
            Console.WriteLine("int2 =");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int2= " + int2);

            uint uint1 = 9;
            Console.WriteLine("uint2 =");
            uint uint2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("uint2= " + uint2);

            long long1 = -10;
            Console.WriteLine("long2 =");
            long long2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long2= " + long2);

            ulong ulong1 = 10;
            Console.WriteLine("ulong2 =");
            ulong ulong2 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulong2" + ulong2);

            float float1 = 3;
            Console.WriteLine("float2 =");
            float float2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("float2= " + float2);

            double double1 =1.7 ;
            Console.WriteLine("double2 =");
            double double2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("double2= " + double2);

            decimal dec1 =3 ;
            Console.WriteLine("dec2 =");
            decimal dec2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("dec2= " + dec2);

            char char1 = 'A';
            Console.WriteLine("char2 =");
            char char2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char2= " + char2);

            string str1 = "Hello";
            Console.WriteLine("str1 = " + str1);
            Console.WriteLine("str2 = ");
            string str2 = Console.ReadLine();
            Console.WriteLine("Str2" + str2);

            object obj1 = "Hello world";
            Console.WriteLine("obj1 = " + obj1);
            Console.WriteLine("obj2 =");
            object obj2 = Console.ReadLine();
            Console.WriteLine("obj2= " + obj2);
            */

            int a = 10;
            int b = 15;
            byte c = (byte)(a + b);
            Console.WriteLine("c = " + c); // явное преобразование

            int num = 2147483647;
            long bigNum = num;

            var e= 1.7654;

            int? num1 = null;
            int? num2 = 6;

            Object y;              //упаковка
            y = 5;
            int z;
            z = (int)y;             //распаковка : int <= object


            //Task 2

            string str11 = "Hello world!";
            string str22 = "How are you?";
            string str33 = "Bye bye";
            Console.WriteLine("\nTask 2:");
            Console.WriteLine("is str1 & str2 equal? {0}", String.Compare(str11, str22));
            Console.WriteLine("str11 + str22 = ", String.Concat(str11, str22)); //сцепление
            Console.WriteLine("str33 copy:", String.Copy(str33)); //str22 = str33 копировние
            Console.WriteLine("str33 on words:");
            foreach (var sub in str33.Split(' ')) //разделение строки на слова
            {
                Console.WriteLine($"{sub}");
            }
            Console.WriteLine("substring of str1: ", str11.Substring(0, 4)); // выделение подстроки 
            Console.WriteLine("input substring: " + str33.Substring(0, 6) + str11); 
            Console.WriteLine("remove substring: " + str33.Remove(2, 4)); // удаление заданной подстроки
            Console.WriteLine($"interpolation: {str33}"); // интерполирование

            string str4 = null;
            string str5 = "";
            string str6 = "abc";
            Console.WriteLine(string.IsNullOrEmpty(str4));          
            Console.WriteLine(string.IsNullOrEmpty(str5));
            Console.WriteLine(string.IsNullOrEmpty(str6));


            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine("sb до изменений =" + sb);
            sb.Remove(1, 1);                 //удаление символов
            sb.Insert(0, 'Z');              //добавление символов в начало
            sb.Append(new char[] { 'A', 'A' });     //добавление символов в конец 
            Console.WriteLine("после изменений"+sb);

            int[,] array = { { 0, 5, 2, }, { 7, 9, 5 }, { 4, 9, 2 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array.Length / 3; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            string[] arrS = { "hello", "my", "world" };
            foreach (string k in arrS)
                Console.Write($"{k} ");
            Console.WriteLine("length = " + arrS.Length);
            arrS[0] = "bye";
            foreach (string k in arrS)
                Console.Write($"{k} ");


            /*
            Console.WriteLine("\n\nTask 3c:");
            int[][] arrSt = new int[3][];
            arrSt[0] = new int[2];
            arrSt[1] = new int[3];
            arrSt[2] = new int[4];

            for (int i = 0; i < 2; i++)
            {
                arrSt[0][i] = Convert.ToInt32(Console.ReadLine());
         
            }
            for (int i = 0; i < 3; i++)
            {
                arrSt[1][i] = Convert.ToInt32(Console.ReadLine());
                Console.Write(arrSt[1][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                arrSt[2][i] = Convert.ToInt32(Console.ReadLine());
                Console.Write(arrSt[2][i] + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(arrSt[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arrSt[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arrSt[2][i] + " ");
            }
            */

            var nArr = new[] { 20, 7.8 };
            var nStr = str33;
            Console.WriteLine("\n\nTask 3d:\nnot tip string: " + nStr);

            // 4
            (int, string, char, string, ulong) cort = (18, "hi", '%', "hello", 16);
            Console.WriteLine("\nTask 4:\n" + cort.Item2 + cort.Item3);
            (var varA, var varB) = (1, "okok"); //raspakovka
            Console.WriteLine(varA);
            Console.WriteLine(varB);
            (int k, byte l) cmpC1 = (12, 43);
            (long z, uint d) cmpC2 = (12, 43);
            Console.WriteLine("is cmpC1 == cmpC2? " + (cmpC1 == cmpC2));

            // 5 task
            Console.WriteLine("\nTask 5:");
            void func(int[] arr, string s)
            {
                int max, min, sum;
                char firstC;
                max = arr.Max<int>();
                min = arr.Min<int>();
                sum = arr.Sum();
                firstC = s[0];
                var T = Tuple.Create(max, min, sum, firstC);
                Console.WriteLine(T);
            }
            string strF = "hello world";
            int[] arrF = { 1, 2, 3, 4, 5 };
            func(arrF, strF);



            Func2();
            Func3();
            void Func2()
            {
                checked
                {
                    int max = int.MaxValue;
                }
            }
            void Func3()
            {
                unchecked
                {
                    int max = int.MaxValue;
                }
            }
        }
    }
}
