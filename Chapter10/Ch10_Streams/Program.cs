using System.IO;
using System.IO.Compression;
using System.Xml;
using static System.Console;

namespace Ch10_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            // define an array of strings
            string[] mascots = new string[] { "Ralphie", "Tater", "Bug", "Tony", "Jerdson", "Librasia", "Kcooper", "Batthias" };

            // define a file to write to using a text writer helper
            string textFile = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10_Streams.txt";
            StreamWriter text = File.CreateText(textFile);

            // enumerate the strings writing each one to the stream
            foreach (string item in mascots)
            {
                text.WriteLine(item);
            }
            text.Dispose(); // close the stream

            // output all the contents of the file to the Console
            WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes.");
            WriteLine(File.ReadAllText(textFile));

            // define a file to write to using the XML writer helper
            string xmlFile = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10_Streams.xml";

            FileStream xmlFileStream = File.Create(xmlFile);
            XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });

            // write the XML declaration
            xml.WriteStartDocument();
            // write a root element
            xml.WriteStartElement("mascots");

            // enumerate the strings writing each one to the stream
            foreach (string item in mascots)
            {
                xml.WriteElementString("mascot", item);
            }

            // write the close root element
            xml.WriteEndElement();
            xml.Dispose();
            xmlFileStream.Dispose();

            // output all the contents of the file to the Console
            WriteLine($"{xmlFile} contains {new FileInfo(xmlFile).Length} bytes.");
            WriteLine(File.ReadAllText(xmlFile));

            // compress the XML output
            string gzipFilePath = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10.gzip";

            FileStream gzipFile = File.Create(gzipFilePath);
            GZipStream compressor = new GZipStream(gzipFile, CompressionMode.Compress);
            XmlWriter xmlGzip = XmlWriter.Create(compressor);
            xmlGzip.WriteStartDocument();
            xmlGzip.WriteStartElement("mascots");
            foreach (string item in mascots)
            {
                xmlGzip.WriteElementString("mascot", item);
            }
            xmlGzip.Dispose();
            compressor.Dispose(); // also closes the underlying stream

            // output all the contents of the compressed file to the Console
            WriteLine($"{gzipFilePath} contains {new FileInfo(gzipFilePath).Length} bytes.");
            WriteLine(File.ReadAllText(gzipFilePath));

            // read a compressed file
            WriteLine("Reading the compressed XML file:");
            gzipFile = File.Open(gzipFilePath, FileMode.Open);
            GZipStream decompressor = new GZipStream(gzipFile, CompressionMode.Decompress);
            XmlReader reader = XmlReader.Create(decompressor);
            while (reader.Read())
            {
                // check if we are currently on an element node named mascot
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "mascot"))
                {
                    reader.Read(); // move to the Text node inside the element
                    WriteLine($"{reader.Value}"); // read its value
                }
            }
            reader.Dispose();
            decompressor.Dispose();
        }
    }
}