using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Serializzazione_4
{
    public class Address
    {
        [XmlIgnore]
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
    }
}
