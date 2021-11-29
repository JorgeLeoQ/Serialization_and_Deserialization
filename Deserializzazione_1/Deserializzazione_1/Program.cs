using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Deserializzazione_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();

            Byte[] ba = File.ReadAllBytes(@"..\output.xml");

            using (StreamReader sr = new StreamReader(new MemoryStream(ba)))
            {
                //Desearillazione
                XmlSerializer xmls = new XmlSerializer(typeof(AddressDetails));
                details = (AddressDetails)xmls.Deserialize(sr);
            }

            Console.WriteLine("StreatName: " + details.StreetName + " City: " + details.City + " No: " + details.HouseNo);
        }
    }
}
