using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dog
    {
        int  _ageInMonth;
        string  _name;
        public Dog(int ageInMonth, string name)
        {
            _ageInMonth = ageInMonth;
            _name = name;
        }
        public void Bark()
        {
            Console.WriteLine($"Gav!!! Gav!!! Dog {_ageInMonth} {_name}");
        }
    }
}
