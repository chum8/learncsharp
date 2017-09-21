using System.IO;
using static System.Console;
using static System.IO.Directory;

namespace Ch10_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a directory path
            string dir = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10_Example";

            // check if it exists
            WriteLine($"Does {dir} exist? {Exists(dir)}");
            // create a directory
            CreateDirectory(dir);
            WriteLine($"Does {dir} exist? {Exists(dir)}");
            // delete a directory
            Delete(dir);
            WriteLine($"Does {dir} exist? {Exists(dir)}");

            string textFile = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10.txt";
            string backupFile = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10.bak";

            // check if a file exists
            WriteLine($"Does {textFile} exist? {File.Exists(textFile)}");

            // create a new text file and write a line to it
            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("\nHello, C#! File created 9-15-2017");
            textWriter.Dispose();
            WriteLine($"Does {textFile} exist? {File.Exists(textFile)}");

            // copy a file and overwrite if it already exists
            File.Copy(textFile, backupFile, true);
            WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

            // read from a text file
            StreamReader textReader = File.OpenText(backupFile);
            WriteLine(textReader.ReadToEnd());
            textReader.Dispose();

            WriteLine($"\nFile Name: {Path.GetFileName(textFile)}"); 
            WriteLine($"File Name without Extensions: { Path.GetFileNameWithoutExtension(textFile)}");
            WriteLine($"File Extension: {Path.GetExtension(textFile)}");
            WriteLine($"Random File Name: {Path.GetRandomFileName()}");
            WriteLine($"Temporary File Name: {Path.GetTempFileName()}");

            string backup = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10.bak";

            var info = new FileInfo(backup);
            WriteLine($"\n{backup} contains {info.Length} bytes.");
            WriteLine($"{backup} was last accessed {info.LastAccessTime}.");
            WriteLine($"{backup} has readonly set to {info.IsReadOnly}"); 
        }
    }
}