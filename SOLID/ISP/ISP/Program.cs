using ISP.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Azul", 2022, 2.5, 5, 2);
            MotorCycle moto = new MotorCycle("Preta", 2022, 1000);

            Console.ReadLine();

        }
    }
}
