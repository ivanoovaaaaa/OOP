using System;
using System.IO;
using System.Threading;
using System.IO.Compression;
using System.Linq;

namespace OOP_Lab13
{
    public static class ISIFileManager
    {
        public static void ISIInspect()
        {
            string classLogInfo = "\n=======================================   ISIFileManager   ===============================================\n";            /// инфа для логгера
            string inspectLog = "";

            DriveInfo[] drives = DriveInfo.GetDrives();                
            string inspectPath = drives[1].Name;                       
            DirectoryInfo directory = new DirectoryInfo(@"D:\Lab13");  

            directory.Create();                                         
            directory.CreateSubdirectory(@"VADInspect");

            DirectoryInfo ISIInspectFiles = new DirectoryInfo(Path.GetFullPath(@"D:\Lab13\VADInspect\VADFiles"));
            if (ISIInspectFiles.Exists)
                ISIInspectFiles.Delete(true);

            string filePath = Path.GetFullPath(@"D:\Lab13\ISIInspect\vaddirinfo.txt");
            FileInfo fileInfo = new FileInfo(filePath);                 /// fileInfo шобы всё работало
            using (StreamWriter sw = fileInfo.CreateText())             /// создаем файл и сразу пишем поток
            {
                sw.WriteLine("jivyvyuvyuvuvfttvbnioononp\n" +
                             "fjjjjjjjjjjjjjjjjjslnnnnnviiiffffffffffffnv\n" +
                             "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkjjjjjjjjjjjjjjjjjjjjjо\n" +
                             "pppppppppppppppppppppppppppppppppppppp!");
                sw.Close();                                             
            }


            string renamePath = Path.GetFullPath(@"D:\Lab13\ISIInspect\vaddirinfoRENAMED.txt");
            FileInfo renameBuf = new FileInfo(renamePath);              /// буфер чтобы удалить созданный ранее RENAMED
            renameBuf.Delete();

            fileInfo.CopyTo(renamePath);
            fileInfo.Delete();


            DirectoryInfo inspectDirInfo = new DirectoryInfo(Path.GetFullPath(@"D:\Lab13\ISIInspect"));
            string files = "";
            for (int i = 0; i < inspectDirInfo.GetFiles().Length; i++)
                files += inspectDirInfo.GetFiles()[i].Name + "; ";          /// имена всех файлов записываем в строку

            string directories = "";
            for (int i = 0; i < inspectDirInfo.GetDirectories().Length; i++)
                directories += inspectDirInfo.GetDirectories()[i];          /// имена всех директориев

            if (inspectDirInfo.Exists)
                inspectLog = classLogInfo +
                             "\nФайлы:                    " + files +
                             "\nПоддиректории:            " + directories +
                             "\nРодительский директорий:  " + inspectDirInfo.Parent.Name +
                             "\n\n==========================================================================================================";


            ISILog.WriteInLog(inspectLog);
        }

        public static void ISIFiles()
        {
            string rootDrivePath = Path.GetFullPath(@"D:\");
            string ISIFilesPath = Path.GetFullPath(rootDrivePath + @"Lab13\ISIFiles");
            string ISIInspectFilesPath = Path.GetFullPath(rootDrivePath + @"Lab13\ISIInspect\ISIFiles");
            string ISIUnzipPath = Path.GetFullPath(rootDrivePath + @"Lab13\ISIInspect\ISIUnzip");
            string musicPath = Path.GetFullPath(rootDrivePath + @"Music");
            string ZIPPath = Path.GetFullPath(rootDrivePath + @"Lab13\ISIInspect\ISIFiles.zip");


            DirectoryInfo ISIFiles = new DirectoryInfo(ISIFilesPath);                        /// создать ISIFIles
            DirectoryInfo ISIInspectFiles = new DirectoryInfo(ISIInspectFilesPath);          /// создать Inspect\Files
            DirectoryInfo ISIUnzip = new DirectoryInfo(ISIUnzipPath);

            if (!ISIFiles.Exists)                                                            /// если нет папки Files,
                ISIFiles.Create();                                                           /// то создаем ее

            if (ISIUnzip.Exists)
                ISIUnzip.Delete(true);

            if (File.Exists(ZIPPath))
                File.Delete(ZIPPath);


            DirectoryInfo musicDirInfo = new DirectoryInfo(musicPath);                       /// путь к Music 
            FileInfo[] filesMusic = musicDirInfo.GetFiles();                                 /// получить все файлы из Music
            foreach (FileInfo file in filesMusic)
                if (file.Extension == ".mp3")
                    file.CopyTo(Path.Combine(ISIFilesPath.ToString(), file.Name), true);     /// скопировать все .mp3 в ISIFiles

            if (ISIInspectFiles.Exists)                                                      /// если есть Inspect\Files,
                ISIInspectFiles.Delete(true);                                               
            if (ISIFiles.Exists)
                ISIFiles.MoveTo(ISIInspectFilesPath);                                        /// перемещаем в Inspect\Files
        }

        public static void MakeArchive()
        {
            string lab13Path = Path.GetFullPath(@"D:\Lab13\");
            string ISIFilesPath = Path.GetFullPath(lab13Path + @"VADFiles");
            string ISIInspectFilesPath = Path.GetFullPath(lab13Path + @"VADInspect\VADFiles");
            string ISIInspectUnzipPath = Path.GetFullPath(lab13Path + @"VADInspect\VADUnzip");
            string ZIPPath = Path.GetFullPath(lab13Path + @"VADInspect\VADFiles.zip");

                                                                                           
            DirectoryInfo VADFiles = new DirectoryInfo(ISIFilesPath);
            ZipFile.CreateFromDirectory(ISIInspectFilesPath, ZIPPath);                      /// архивируем

            DirectoryInfo ISIInspectFiles = new DirectoryInfo(ISIInspectFilesPath);         /// если остался Inspect\Files,
            if (ISIInspectFiles.Exists)                                                     /// то удаляем его
                ISIInspectFiles.Delete(true);

            DirectoryInfo ISIInspectUnzip = new DirectoryInfo(ISIInspectUnzipPath);         /// создаем папку для разархивации,
            if (ISIInspectUnzip.Exists)                                                     /// а если на существует,
                ISIInspectUnzip.Delete(true);                                               /// то удаляем 
            ISIInspectUnzip.Create();

            using (ZipArchive archive = ZipFile.OpenRead(ZIPPath))                         
            {                                                                               /// для разархивации в папку Unzip
                var result = from currEntry in archive.Entries
                             where !String.IsNullOrEmpty(currEntry.Name)
                             select currEntry;
                foreach (ZipArchiveEntry entry in result)
                    entry.ExtractToFile(Path.Combine(ISIInspectUnzipPath, entry.Name));    
            }
            

        }
    }
}
