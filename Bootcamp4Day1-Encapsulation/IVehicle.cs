using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public interface IVehicle
    {
        decimal GetCurrentSpeed();
        void Accelerate();
        void Accelerate(decimal acceleration);
        void Brake();
        void Brake(decimal brake);
        void Steer(decimal direction);
        void Reverse();
        decimal GetCurrentDirection();
    }

}
