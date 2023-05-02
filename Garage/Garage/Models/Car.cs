using Garage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Car : Vehicle
    {
        public Car()
        {
            this.Type = VehicleEnum.Car;
        }
    }
}
