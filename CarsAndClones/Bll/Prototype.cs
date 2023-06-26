using CarsAndClones.DI;
using CarsAndClones.Enums;
using CarsAndClones.Settings;

namespace CarsAndClones.Bll
{
    public class Prototype : IPrototype
    {
        private ICar carClone;

        public Prototype() { }
        public Prototype(ICar car)
        {
            Body = car.Body;
            Colour = car.Colour;
            Engine = car.Engine;
            GearBox = car.GearBox;
            Options = car.Options;
        }

        public Bodies Body { get; private set; }
        public Colours Colour { get; private set; }
        public Engines Engine { get; private set; }
        public GearBoxes GearBox { get; private set; }
        public List<Options> Options { get; private set; }

        public ICar Clone()
        {
            carClone = new Car();
            carClone.Body = Body;
            carClone.Colour = Colour;
            carClone.Engine = Engine;
            carClone.GearBox = GearBox;
            carClone.Options = Options;
            return carClone;
        }
    }
}
