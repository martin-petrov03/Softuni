using System;
using System.IO;
using System.IO.Compression;

namespace _05.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string pictureFilesPath = "copyMe.png";
            string textFilesPath = "text.txt";
            string targetPath = "../../../result.zip";
            
            using (var archive = ZipFile.Open(targetPath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(pictureFilesPath, Path.GetFileName(pictureFilesPath));
                archive.CreateEntryFromFile(textFilesPath, Path.GetFileName(textFilesPath));
            }
        }
    }
}
