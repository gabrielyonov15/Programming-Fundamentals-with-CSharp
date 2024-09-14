namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string filePath = Console.ReadLine();
                if (string.IsNullOrEmpty(filePath))
                {
                    Console.WriteLine("No file path provided.");
                    return;
                }
                ExtractFileNameAndExtension(filePath);
            }
            static void ExtractFileNameAndExtension(string filePath)
            {
                int lastBackslashIndex = filePath.LastIndexOf('\\');
                if (lastBackslashIndex == -1)
                {
                    Console.WriteLine("Invalid file path.");
                    return;
                }
                string fileNameWithExtension = filePath.Substring(lastBackslashIndex + 1);
                int lastDotIndex = fileNameWithExtension.LastIndexOf('.');
                if (lastDotIndex == -1)
                {
                    Console.WriteLine("No file extension found.");
                    return;
                }
                string fileName = fileNameWithExtension.Substring(0, lastDotIndex);
                string fileExtension = fileNameWithExtension.Substring(lastDotIndex + 1);
                Console.WriteLine($"File name: {fileName}");
                Console.WriteLine($"File extension: {fileExtension}");
            }
        }
    }