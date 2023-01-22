namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
//Write a program that copies the contents of a binary file(e.g.copyMe.png) to another
//binary file(e.g.copyMe-copy.png) using FileStream.You are not allowed to use the File
//class or similar helper classes.
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream source = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream output = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[512];
                        int size = source.Read(buffer, 0, 512);
                        if (size == 0)
                        {
                            break;
                        }
                        output.Write(buffer);
                    }
                }
            }
        }
    }
}
