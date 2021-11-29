using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

//Obbiettivo è quello di deserializzare il seguente file .xml

//<? xml version = "1.0" encoding = "utf-8" ?>
//   < AddressDetails xmlns:xsi = "http://www.w3.org/2001/XMLSchema-instance" xmlns: xsd = "http://www.w3.org/2001/XMLSchema" >     
//         < HouseNo > 20 </ HouseNo >
//         < StreetName > Via Torino </ StreetName >
//            < City > Roma </ City >
//          </ AddressDetails >

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

            Console.WriteLine("StreatName: " + details.StreetName);
            Console.WriteLine("City: " + details.City);
            Console.WriteLine("No: " + details.HouseNo);

            //Output
            //StreatName: Via Torino
            //City: Roma
            //No: 20
        }
    }
}
