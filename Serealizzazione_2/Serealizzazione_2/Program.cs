using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serealizzazione_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione di un oggetto
            PersonalDetails p = new PersonalDetails();
            p.Name = "Carlo";
            p.Age = 20;
            p.address = new Address();
            p.address.HouseNo = 20;
            p.address.StreetName = "Via Torino";
            p.address.City = "Roma";

            //serealizzazione
            string ret = "";
            XmlSerializer xmls = new XmlSerializer(typeof(PersonalDetails));
            using(StringWriter sw = new StringWriter())
            {
                using(XmlWriter xmlw = XmlWriter.Create(sw))
                {
                    xmls.Serialize(xmlw, p);
                }
                ret = sw.ToString();
            }

            //output
            Console.WriteLine(ret);
        }
    }
}
