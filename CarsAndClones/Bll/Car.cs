using CarsAndClones.DI;
using CarsAndClones.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndClones.Bll
{
    public class Car : ICar
    {
        public string Model { get; set; }
        public Bodies Body { get; set; }
        public Colours Colour { get; set; }
        public Engines Engine { get; set; }
        public GearBoxes GearBox { get; set; }
        public List<Options> Options { get; set; }
    }
}
