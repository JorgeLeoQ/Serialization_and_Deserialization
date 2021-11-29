using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

//Deserializzare il segunete file xml 

//<? xml version = "1.0" encoding = "utf-8" ?>
//   < AddressDetails xmlns:xsi = "http://www.w3.org/2001/XMLSchema-instance" xmlns: xsd = "http://www.w3.org/2001/XMLSchema" >
//         < HouseNo > 20 </ HouseNo >
//         < StreetName > Via Torino </ StreetName >
//            < City > Roma </ City >
//          </ AddressDetails >

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
            using(TextReader tr = new StreamReader(@"..\output.xml"))
            {
                details = (AddressDetails)xmls.Deserialize(tr);
            }

            Console.WriteLine("StreetName: " + details.StreetName);
            Console.WriteLine("City: " + details.City);
            Console.WriteLine("HouseNo: " + details.HouseNo);

            //output
            //StreetName: Via Torino
            //City: Roma
            //HouseNo: 20 
        }
    }
}
