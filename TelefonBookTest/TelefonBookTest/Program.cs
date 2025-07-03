using TelefonBoofLib;

namespace TelefonBookTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelepfoneBook telepfoneBook = new TelepfoneBook();
            while (true)
            {
                Console.WriteLine("Select an action");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search by Phone number");
                Console.WriteLine("3. Search by Address");
                Console.WriteLine("4. Display all Contacts");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        telepfoneBook.AddContact();
                        break;
                    case "2":

                        Console.Write("Enter Phone Number to search: ");
                        var phoneNumber = Console.ReadLine();

                        telepfoneBook.SearchContactByPhone(phoneNumber);
                        break;
                        case "3":
                        Console.WriteLine("Enter Address to search:");
                        var address = Console.ReadLine();

                        telepfoneBook.SearchContactByAddress(address);
                        break;
                    case "4":
                        telepfoneBook.DisplayAllContacts();
                        break;
                    default:
                        Console.WriteLine("Invalid action. Please try again.");
                        break;
                }
            }


            //var phomeNumber = Console.ReadLine();
            //telepfoneBook.SearchContactByPhone(phomeNumber);

        }
    }
}
