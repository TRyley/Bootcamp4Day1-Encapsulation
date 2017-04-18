using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class Vehicle : IVehicle
    {
        private decimal _speed;
        private const decimal _acceleration = 1;
        private bool _engineStatus;

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

        public void Brake(decimal brake)
        {
            if (_speed != 0)
            {
                _speed -= brake;
            }
        }

        public void Brake()
        {
            var currentSpeed = GetCurrentSpeed();
            decimal newSpeed = currentSpeed;
            if (currentSpeed != 0)
            {
                newSpeed -= _acceleration;
                _speed = newSpeed;
            }
        }

        public void StartEngine()
        {
            _engineStatus = true;
        }
        public void StopEngine()
        {
            _engineStatus = false;
        }

        public bool IsEngineOn()
        {
            return _engineStatus;
        }
    }
}
