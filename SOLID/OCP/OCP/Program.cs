using OCP.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car vihicle = new Car("Preto", 2022, 2.0, 5, 4);
            }
            else
            {
                Motorcycle vihicle = new Motorcycle("Branca", 2023, 600);

            }
            Console.ReadLine();
            


        }
    }
}
