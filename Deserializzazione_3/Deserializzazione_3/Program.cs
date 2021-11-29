using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

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
            using(TextReader tr = new StreamReader(@"C:\Users\Jorge\Documents\example1.xml"))
            {
                details = (AddressList)xmls.Deserialize(tr);
            }

            foreach(Address address in details.AddrList)
            {
                Console.WriteLine("House No: " + address.HouseNo +
                    " StreetName " + address.StreetName + " City " +
                    address.City);
            }
        }
    }
}
