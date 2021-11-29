using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace serealizzazione
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione del oggetto
            AddressDetails details = new AddressDetails();
            details.HouseNo = 0;
            details.StreetName = "Via Torino";
            details.City = "ROMA";

            //Serealizzazione
            string ret = "";
            XmlSerializer xmls = new XmlSerializer(typeof(AddressDetails));

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xmlw = XmlWriter.Create(sw))
                {
                    xmls.Serialize(xmlw, details);
                }
                ret = sw.ToString();
            }

            //output
            Console.WriteLine(ret);
        }
    }
}
