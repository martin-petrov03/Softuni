using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pictureFilePath = @"../../../copyMe.png";
            string copiedPictureFilePath = @"../../../copyMe-copyMe-copy.png";

            using (FileStream streamReader = new FileStream(pictureFilePath, FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream(copiedPictureFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArr = new byte[4096];
                        int size = streamReader.Read(byteArr, 0, byteArr.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArr, 0, size);                        
                    }
                }
            }
        }
    }
}
