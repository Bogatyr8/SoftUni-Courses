namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
//Write a program that traverses a given directory for all files with the given extension.Search through the first level of the directory only.
//Write information about each found file in a text file named report.txt and it should be saved on the Desktop.The files should be grouped by
//their extension.Extensions should be ordered by the count of their files descending, then by name alphabetically.Files under an extension
//should be ordered by their size.report.txt should be saved on the Desktop.Ensure the desktop path is always valid, regardless of the user.
            
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new SortedDictionary<string, List<FileInfo>>();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }

            var orderedExtensionFiles = extensionsFiles.OrderByDescending(ef => ef.Value.Count);

            StringBuilder sb = new StringBuilder();

            foreach (var extensionFiles in orderedExtensionFiles)
            {
                sb.AppendLine(extensionFiles.Key);

                var orderedFiles = extensionFiles.Value.OrderByDescending(f => f.Length);
                foreach (var file in extensionFiles.Value)
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }

            return sb.ToString();

        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}
