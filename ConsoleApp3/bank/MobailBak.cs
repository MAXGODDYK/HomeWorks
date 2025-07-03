using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class MobailBak
    {
        private List<Creitcart> _listOfCreaditCards = new List<Creitcart>();

        
        private void Communication()
        {
            while (true)
            {
                Console.WriteLine("1. Add card");
                Console.WriteLine("2. Add balence to the cart");
                Console.WriteLine("3. Get balens from the cart");
                Console.WriteLine("4. Get total ballance");

                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        // Add card
                        break;
                    case 2:
                        //Add balence;
                        break;
                    case 3:
                        // Get balence
                        break;
                    case 4:
                        // Total balance
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
