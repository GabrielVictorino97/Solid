using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Vehicles
{
    interface IVehicleCar: IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
