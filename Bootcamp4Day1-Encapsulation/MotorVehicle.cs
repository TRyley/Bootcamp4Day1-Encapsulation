using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class MotorVehicle : IVehicle
    {
        private decimal _speed;
        private const decimal _acceleration = 1;
        private bool _engineStatus;
        private const decimal _reverseSpeed = -2;
        private decimal _direction;
        private Engine _engine;

        public MotorVehicle(Engine engine)
        {
            _engine = engine;
        }
        public decimal GetCurrentSpeed()
        {
            return _speed;
        }
        public void Accelerate()
        {
            _speed = _engine.Accelerate(_speed);
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

        public void Reverse()
        {
            var currentSpeed = GetCurrentSpeed();
            decimal newSpeed = currentSpeed;

            if (currentSpeed > 0)
            {
                Brake(currentSpeed);
            }

            newSpeed += _reverseSpeed;
            _speed = newSpeed;
        }

        public void Steer(decimal direction)
        {
            _direction = direction;
        }

        public decimal GetCurrentDirection()
        {
            return _direction;
        }
        public decimal GetEngineSize()
        {
            return _engine.GetEngineSize();
        }
    }
}
