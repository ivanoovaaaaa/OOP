using System;

    public class Printer : AbsPrinter { }
    public abstract class AbsPrinter
    {
        public void IamPrinting(Printed_edition obj)
        {
            Console.WriteLine("Тип этого объекта: " + obj.GetType());
            Console.WriteLine("Данные :" + obj.ToString());
        }
    }

