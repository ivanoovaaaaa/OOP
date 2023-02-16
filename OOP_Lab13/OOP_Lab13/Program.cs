using System;

namespace OOP_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ISILog.WriteLogInfo();
                ISIDiskInfo.GetDiskInfo();
                ISIFileInfo.GetFileInfo();
                ISIDirInfo.GetDirInfo();
                ISIFileManager.ISIFiles();
                ISIFileManager.MakeArchive();
                ISIFileManager.ISIInspect();

                ISILog.ReadLog();
                ISILog.SearchLog();
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine("Ошибка! Директорий не найден.\n" + e.Message + 
                                  "\nОбратиться за помощью");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Ошибка! Файл уже существует или используется другим процессом.\n" +
                                  e.Message + "\nОбратиться за помощью");
            }
            catch (Exception e)
            {
                Console.WriteLine("Непредвиденная ошибка!\n" + e.Message + 
                                  "\nОбратиться за помощью");
            }
        }
    }
}
