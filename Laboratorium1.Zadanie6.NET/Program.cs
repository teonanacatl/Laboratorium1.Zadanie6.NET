namespace Laboratorium1.Zadanie6.NET
{
    class Program
    {
        static void Main()
        {
            string sourceFilePath = @"C:\path\to\your\source\file";
            string destinationFilePath = @"C:\path\to\your\destination\file";

            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine($"The source file '{sourceFilePath}' does not exist.");
                return;
            }

            using FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open);
            using FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create);
            sourceStream.CopyTo(destinationStream);
        }
    }
}