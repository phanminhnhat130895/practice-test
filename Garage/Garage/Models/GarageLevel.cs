using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class GarageLevel
    {
        public int Id { get; set; }
        public int CarParkingLots { get; set; }
        public int MotobikeParkingLots { get; set; }
        public int Level { get; set; }
    }
}
