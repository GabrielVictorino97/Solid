using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Vehicles
{
    class MotorCycle : IVehicleMotorCycle
    {
        private string color;
        private int year;
        private double engine;

        public MotorCycle(string color, int year, double engine)
        {
            ConfigureMotorCycle(color, year, engine);
        }

        public void ConfigureMotorCycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando um moto ano {year}, motor {engine} cilindradas da cor {color}.");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os Motores!");
        }
    }
}
