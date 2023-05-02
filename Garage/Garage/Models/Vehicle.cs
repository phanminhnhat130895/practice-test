using Garage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string LicencePlate { get; set; }
        protected VehicleEnum Type { get; init; }
    }
}
