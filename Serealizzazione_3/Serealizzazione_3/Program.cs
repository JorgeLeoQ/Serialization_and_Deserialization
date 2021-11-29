using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serealizzazione_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione di un oggetto
            AddressDetails details = new AddressDetails();
            details.HouseNo = 20;
            details.StreetName = "Via Torino";
            details.City = "Roma";

            //Serealizzazione.
            XmlSerializer xmls = new XmlSerializer(typeof(AddressDetails));

            using (TextWriter tw = new StreamWriter(@"..\output.xml"))
            {
                xmls.Serialize(tw, details);
            }
        }
    }
}
