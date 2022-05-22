using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        void OnLoad(object sender, EventArgs args)
        {
            var deserializer = new XmlSerializer(typeof(Persons));
            var xml = File.ReadAllText(@"../../persons.xml");

            using (var reader = new StringReader(xml))
            {
                var persons = (Persons)deserializer.Deserialize(reader);

                for (var i = 0; i < persons.PersonList.Count; i++)
                {
                    var person = persons.PersonList[i];
                    this.personalData.Nodes.Add(new TreeNode($"Person: {person.FirstName} {person.LastName}"));
                    
                    var childrenNodes = this.personalData.Nodes[i].Nodes;
                    childrenNodes.Add(new TreeNode($"Location: {person.City}, {person.Country}"));
                    childrenNodes.Add(new TreeNode($"Email: {person.Email}"));
                }
            }
        }
    }

    [XmlRoot("persons")]
    public struct Persons
    {
        [XmlElement("person")] public List<Person> PersonList;
    }

    public struct Person
    {
        [XmlAttribute("firstname")] public string FirstName { get; set; }
        [XmlAttribute("lastname")] public string LastName { get; set; }
        [XmlAttribute("city")] public string City { get; set; }
        [XmlAttribute("country")] public string Country { get; set; }
        [XmlAttribute("email")] public string Email { get; set; }
    }
}