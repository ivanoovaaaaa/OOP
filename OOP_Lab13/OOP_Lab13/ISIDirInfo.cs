using System;
using System.IO;

namespace OOP_Lab13
{
    public static class ISIDirInfo
    {
        public static void GetDirInfo()
        {
            string path = Path.GetFullPath(@"D:\3 sem\OOP\git_oop\OOP");
            string DirInfoLog = "";

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (dirInfo.Exists)
                DirInfoLog = "\n=========================================   VADDirInfo   =================================================\n" +
                             "\nКоличество файлов:        " + dirInfo.GetFiles().Length +
                             "\nВремя создания:           " + dirInfo.LastWriteTime +
                             "\nКол-во поддиректориев:    " + dirInfo.GetDirectories().Length +
                             "\nРодительский директорий:  " + dirInfo.Parent.Name;

            ISILog.WriteInLog(DirInfoLog);
        }
    }
}
