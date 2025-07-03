using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TelefonBoofLib
{
    public class TelepfoneBook
    {
        private List<Contact> _listOfContacts= new List<Contact>();

        public void AddContact()
        {
            Console.Write("Enter Fist Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            var lastName = Console.ReadLine();

            Console.Write("Enter Telphone Number: ");
            var telphoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            var address = Console.ReadLine();



            _listOfContacts.Add(new Contact(firstName, lastName, telphoneNumber)
            {
                Address = address
            });
        }


        public void SearchContactByPhone(string phone)
        {
            Console.WriteLine("");
            foreach (var contact in _listOfContacts)
            {
                if (contact.TelphoneNumber == phone)
                {
                    Console.WriteLine(contact.PrintTostring());
                }
            }
        }

        public void SearchContactByAddress(string address)
        {
            Console.WriteLine("");
            foreach (var contact in _listOfContacts)
            {
                if (contact.Address == address)
                {
                    Console.WriteLine(contact.PrintTostring());
                }
            }
        }

        public void DisplayAllContacts()
        {
            foreach (var contact in _listOfContacts)
            {
                Console.WriteLine(contact.PrintTostring());
            }
        }
    }
}
