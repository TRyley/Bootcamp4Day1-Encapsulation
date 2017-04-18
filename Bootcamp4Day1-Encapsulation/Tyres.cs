using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class Tyres
    {
        private decimal _speed;
        public void ChangeSpeed(decimal speed)
        {
            _speed += speed;
        }

        public decimal GetSpeed()
        {
            return _speed;
        }
    }
}
