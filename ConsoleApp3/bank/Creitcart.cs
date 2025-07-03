using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    
    internal class Creitcart
    {
        private string _cartNumber;
        private CurrensiesEnum _currensy;
        private double _balance = 0;
        public Creitcart(string CartNumber, CurrensiesEnum currensy)
        {
            _cartNumber = CartNumber;
            _currensy = currensy;
        }

        public void AddMoney(double sum)
        {
            _balance += sum;
        }   

        public void GetMoney(double sum)
        {
            _balance  -= sum;
        }

        public string GetCartNumber()
        {
            return _cartNumber;
        }

        public CurrensiesEnum GetCurrensy()
        {
            return _currensy;
        }
    }
}
