using System;
using System.IO;

namespace OOP_Lab13
{
    public static class ISIFileInfo
    {
        public static void GetFileInfo()
        {
            string path = Path.GetFullPath(@"D:\3 sem\OOP\git_oop\OOP\OOP_Lab13\OOP_Lab13\isilog.txt");
            string classLogInfo = "\n=========================================   VADFileInfo   ================================================\n";
            string fileInfoLog = "";

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
                fileInfoLog = classLogInfo +
                              "\nПолный путь:              " + path +
                              "\nИмя файла:                " + fileInfo.Name +
                              "\nРазмер файла:             " + fileInfo.Length + " KB" +
                              "\nРасширение:               " + fileInfo.Extension +
                              "\nДата изменения:           " + fileInfo.LastWriteTime;

            ISILog.WriteInLog(fileInfoLog);
        }
    }
}
