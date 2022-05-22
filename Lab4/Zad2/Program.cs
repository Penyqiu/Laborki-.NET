using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Zad2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var database = new PersonDatabase();

            database.AddPersons(
                new Person { Name = "Marcin", Surname = "Kowalski", Age = 22, Location = "Zielona Góra" },
                new Person { Name = "Daniel", Surname = "Kowalski", Age = 24, Location = "Racula" },
                new Person { Name = "Dominik", Surname = "Kowalski", Age = 23, Location = "Zielona Góra" }
            );

            var databaseXml = database.SerializeToString();
            Console.WriteLine("databaseXml = " + databaseXml);

            PersonDatabase databaseDeserialized;
            using (var stream = new MemoryStream(Encoding.Unicode.GetBytes(databaseXml)))
            {
                databaseDeserialized = PersonDatabase.DeserializeFromString(stream);
            }

            Console.WriteLine("databaseDeserialized = " + databaseDeserialized);
        }
    }

    public class PersonDatabase
    {
        private readonly List<Person> _personList = new List<Person>();

        public void AddPersons(params Person[] person)
        {
            this._personList.AddRange(person);
        }
        
        public void RemovePerson(Person person)
        {
            this._personList.Remove(person);
        }
        
        public Person FindPerson(Predicate<Person> personPredicate)
        {
            return this._personList.Find(personPredicate);
        }

        public static PersonDatabase DeserializeFromString(Stream databaseXml)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            var personList = serializer.Deserialize(databaseXml) as List<Person> 
                             ?? throw new InvalidDataException("Could not deserialize person database from xml");

            var database = new PersonDatabase();
            database._personList.AddRange(personList);

            return database;
        }
        
        public string SerializeToString()
        {
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(List<Person>));
                serializer.Serialize(writer, this._personList);

                return writer.ToString();
            }
        }

        public override string ToString()
        {
            return string.Join(", ", this._personList);
        }
    }

    [Serializable]
    [XmlRoot("persons")]
    public struct Person
    {
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlAttribute]
        public string Surname { get; set; }
        
        [XmlAttribute]
        public int Age { get; set; }
        
        [XmlAttribute]
        public string Location { get; set; }
        
        [XmlElement]
        public List<Interest> Interests { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, {this.Surname}, {this.Age}, {this.Location}, {this.Interests}";
        }
    }

    [Serializable]
    public struct Interest
    {
        [XmlAttribute]
        public string Name { get; set; }
        
        [XmlAttribute]
        public int Priority { get; set; }
    }
}