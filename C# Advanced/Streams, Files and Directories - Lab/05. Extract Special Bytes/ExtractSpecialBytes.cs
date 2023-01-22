namespace ExtractBytes
{
    using System;
    using System.IO;
    public class ExtractBytes
    {
        static void Main()
        {
//You are given a binary file(e.g.example.png) and a text file(e.g.bytes.txt), holding a list of
//bytes in the range[0…255]. Write a program to extract occurrences of all given bytes from the
//input file to an output binary file(e.g.output.bin).
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (FileStream bytes = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] bytebuffer = new byte[bytes.Length];
                    bytes.Read(bytebuffer, 0, (int)bytes.Length);
                    byte[] imageBuffer = new byte[image.Length];
                    image.Read(imageBuffer, 0, (int)image.Length);
                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        for (int i = 0; i < imageBuffer.Length; i++)
                        {
                            for (int j = 0; j < bytebuffer.Length; j++)
                            {
                                if (imageBuffer[i] == bytebuffer[j])
                                {
                                    output.Write(new byte[] { imageBuffer[i] });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
