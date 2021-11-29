using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

//<? xml version = "1.0" encoding = "utf-16" ?>
//      < AddressList >
//        < Address >
//          < HouseNo > 10 </ HouseNo >
//          < StreetName > Via Milano </ StreetName >
//          < City > Roma </ City >
//        </ Address >
//        < Address >
//          < HouseNo > 20 </ HouseNo >
//          < StreetName > Via Torino </ StreetName >
//             < City > Venezia </ City >
//           </ Address >
//         </ AddressList >

namespace Deserializzazione_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione della lista
            AddressList details = new AddressList();

            //Deserializzazione
            XmlSerializer xmls = new XmlSerializer(typeof(AddressList));
            using(TextReader tr = new StreamReader(@"..\example1.xml"))
            {
                details = (AddressList)xmls.Deserialize(tr);
            }

            foreach(Address address in details.AddrList)
            {
                Console.WriteLine("House No: " + address.HouseNo);
                Console.WriteLine("StreetName: " + address.StreetName);
                Console.WriteLine("City: " + address.City);
                Console.WriteLine();
            }

            //output
            //House No: 10
            //StreetName: Via Milano
            //City: Roma

            //House No: 20
            //StreetName: Via Torino
            //City: Venezia
        }
    }
}
