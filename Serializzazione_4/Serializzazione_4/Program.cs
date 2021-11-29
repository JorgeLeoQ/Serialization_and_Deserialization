using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serializzazione_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione di un oggetto 
            PersonalDetails p = new PersonalDetails();
            p.Name = "Carlo";
            p.Age = 20;
            p.Address = new Address();
            p.Address.StreetName = "Via Torino";
            p.Address.HouseNo = 20;
            p.Address.City = "Roma";

            //Serializzaione
            XmlSerializer serializer = new XmlSerializer(typeof(PersonalDetails));

            using(TextWriter writer = new StreamWriter(@"..\output.xml"))
            {
                serializer.Serialize(writer, p);
            }
        }
    }
}
