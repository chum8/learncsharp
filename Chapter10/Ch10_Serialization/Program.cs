using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using Newtonsoft.Json;

namespace Ch10_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object graph
            var people = new List<Person>
            {
                new Person(31100) {FirstName = "Douglas", LastName = "Singer", DateOfBirth=new DateTime(1982, 3, 8) },
                new Person(31488322324) {FirstName = "Simon", LastName = "Soughs", DateOfBirth=new DateTime(1948, 9, 8)},
                new Person(64400) {FirstName = "Mark", LastName = "Soughs", DateOfBirth=new DateTime(1982, 12, 28) },
                new Person(3940) {FirstName = "Laura", LastName = "Demick", DateOfBirth=new DateTime(1983, 6, 19), Children = new HashSet<Person> { new Person(0M) { FirstName = "Edmund", LastName = "Singer", DateOfBirth = new DateTime(2009, 11, 26) },  new Person(0M) { FirstName = "Lavinia", LastName = "Singer", DateOfBirth = new DateTime(2012, 5, 19) } } }
            };

            // create a file to write to
            string xmlFilePath = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10_People.xml";
            FileStream xmlStream = File.Create(xmlFilePath);

            // create an object that will format as List of Persons as XML
            var xs = new XmlSerializer(typeof(List<Person>));

            // serialize the object graph to the stream
            xs.Serialize(xmlStream, people);

            // you must close the stream to release the file lock
            xmlStream.Dispose();

            WriteLine($"Written {new FileInfo(xmlFilePath).Length} bytes of XML to {xmlFilePath}");
            WriteLine();

            // display the serialized object graph
            WriteLine(File.ReadAllText(xmlFilePath));

            FileStream xmlLoad = File.Open(xmlFilePath, FileMode.Open);
            // deserialize and cast the object graph into a List of Person
            var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
            foreach (var item in loadedPeople)
            {
                WriteLine($"{item.LastName} has {item.Children.Count} children."); 
            }
            xmlLoad.Dispose();

            // create a file to write to
            string jsonFilepath = @"C:\Users\dms\Documents\Visual Studio 2017\Projects\Chapter10\Ch10_People.json";
            StreamWriter jsonStream = File.CreateText(jsonFilepath);

            // create an object that will format as JSON
            var jss = new JsonSerializer();

            // serialize the object graph into a string
            jss.Serialize(jsonStream, people);

            // you must dispose the stream to release the file lock
            jsonStream.Dispose();

            WriteLine();
            WriteLine($"Written {new FileInfo(jsonFilepath).Length} bytes of JSON to: {jsonFilepath}");

            // Display the serialized object graph
            WriteLine(File.ReadAllText(jsonFilepath)); 
        }
    }
}