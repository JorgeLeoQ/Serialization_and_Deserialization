using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serializzazione_4
{
    [XmlRoot("NewRoot")]
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address;
    }
}
