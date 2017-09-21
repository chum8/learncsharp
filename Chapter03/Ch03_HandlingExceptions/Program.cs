using System;
using static System.Console;
using System.IO;

namespace Ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");

            string path = @"C:\Users\DMS\Documents\Visual Studio 2017\Projects\LearnCSharp\Chapter03";
            FileStream file = null;
            StreamWriter writer = null;
            try
            {
                if (Directory.Exists(path))
                {
                    file = File.OpenWrite(Path.Combine(path, "file.txt"));
                    writer = new StreamWriter(file);
                    writer.WriteLine("Hello, C#!");
                }
                else
                {
                    WriteLine($"{path} does not exist!");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                    WriteLine("The writer's unmanaged resources have been disposed.");
                }
                if (file != null)
                {
                    file.Dispose();
                    WriteLine("The file's unmanaged resources have been disposed.");
                }
            }

            using (FileStream file2 = File.OpenWrite(Path.Combine(path, "file2.txt")))
            {
                using (StreamWriter writer2 = new StreamWriter(file2))
                {
                    try
                    {
                        writer2.WriteLine("Welcome, .NET Core!");
                    }
                    catch (Exception ex)
                    {
                        WriteLine($"{ex.GetType()} says {ex.Message}");
                    }
                }
            }
        }
    }
}