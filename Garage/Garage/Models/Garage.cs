using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Garage
    {
        public Garage()
        {
            this.Levels = new List<GarageLevel>();
            this.Cars = new List<Car>();
            this.Motobikes = new List<Motobike>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<GarageLevel> Levels { get; set; }

        public List<Car> Cars { get; set; }
        public List<Motobike> Motobikes { get; set; }
    }
}
