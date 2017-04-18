using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class Bicycle: IVehicle
    {
        private decimal _speed;
        private const decimal _acceleration = 1;

        public decimal GetCurrentSpeed()
        {
            return _speed;
        }

        public void Accelerate()
        {
            var currentSpeed = GetCurrentSpeed();
            decimal newSpeed = currentSpeed;
            newSpeed += _acceleration;
            _speed = newSpeed;
        }
        public void Accelerate(decimal acceleration)
        {
            _speed += acceleration;
        }

        public void Brake()
        {
            _speed -= _acceleration;
        }

        public void Brake(decimal brake)
        {
            _speed -= brake;
        }

        public void Steer(decimal direction)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public decimal GetCurrentDirection()
        {
            throw new NotImplementedException();
        }
    }
}
