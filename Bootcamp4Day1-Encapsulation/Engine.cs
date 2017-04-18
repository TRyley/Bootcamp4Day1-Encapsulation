using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp4Day1_Encapsulation
{
    public class Engine
    {
        public decimal size { get; set; }

        public Engine()
        {
            size = 10;
        }
        public Engine(decimal givenSize)
        {
            size = givenSize;
        }
        public decimal Accelerate(decimal speed)
        {
           return speed += 1;
        }
        public decimal GetEngineSize()
        {
            return size;
        }
    }
}
