using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Deserializzazione_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione di un oggetto 
            AddressDetails details = new AddressDetails();

            //Deserializzazione 
            XmlSerializer xmls = new XmlSerializer(typeof(AddressDetails));
            using(TextReader tr = new StreamReader(@"C:\output.xml"))
            {
                details = (AddressDetails)xmls.Deserialize(tr);
            }

            Console.WriteLine(details.City.ToString());
        }
    }
}
