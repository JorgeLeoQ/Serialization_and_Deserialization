using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Deserializzazione_3
{
    public class AddressList
    {
        [XmlElement("Address")]
        public List<Address> AddrList { get; set; }
    }
}
