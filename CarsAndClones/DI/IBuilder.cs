using CarsAndClones.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndClones.DI
{
    public interface IBuilder
    {
        IBuilder SetBody(Bodies body);
        IBuilder SetColour(Colours color);
        IBuilder SetEngine(Engines engine);
        IBuilder SetGearBox(GearBoxes gearBox);
        IBuilder SetOptions(List<Options> options);
        ICar Build();
    }
}
