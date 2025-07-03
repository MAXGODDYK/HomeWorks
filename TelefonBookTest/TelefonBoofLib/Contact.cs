using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBoofLib
{
    public class Contact
    {
        public string FistName;
        public string LastName;
        public string TelphoneNumber;
        public string Address;

        public Contact(string fistName, string lastName, string telphoneNumber)
        {
            FistName = fistName;
            LastName = lastName;
            TelphoneNumber = telphoneNumber;
        }

        public string PrintTostring()
        {
            return $@"
Fist Name: {FistName}
Last Name: {LastName}
Telphone Number: {TelphoneNumber}
Address: {Address}";
        }
    }
}
