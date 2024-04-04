using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class PinNumber
    {
        private int _pinNumber;
        public int UserPinNumber
        {
            get { return _pinNumber; }
            set { _pinNumber = value; }
        }
        public int GetPinNumber(int value)
        {
            return UserPinNumber = value;
        }
    }
}
