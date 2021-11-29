using System;
using System.Collections.Generic;
using System.Text;

namespace Deserializzazione_1
{
    public class AddressDetails
    {

        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        private string PoAddress { get; set; }   // Private: non è serializzato
    }
}
