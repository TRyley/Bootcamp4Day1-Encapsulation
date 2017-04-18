using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class Car: Vehicle
    {
        private decimal _speed;
        private const decimal _reverseSpeed = 1;

        public void Reverse()
        {
            var currentSpeed = GetCurrentSpeed();
            decimal newSpeed = currentSpeed;

            while(currentSpeed > 0)
            {
                Brake(0.1M);
            }

            newSpeed -= _reverseSpeed;
            _speed = newSpeed;
        }
    }
}
