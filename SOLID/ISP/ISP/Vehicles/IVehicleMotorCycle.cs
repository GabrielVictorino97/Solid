﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Vehicles
{
    interface IVehicleMotorCycle : IVehicle
    {
        void ConfigureMotorCycle(string color, int year, double engine);
    }
}