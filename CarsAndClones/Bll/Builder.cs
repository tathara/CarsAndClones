using CarsAndClones.DI;
using CarsAndClones.Enums;
using CarsAndClones.Settings;

namespace CarsAndClones.Bll
{
    public class Builder : IBuilder
    {
        private ICar car;

        public Builder() { }

        public Builder(Configuration configuration)
        {
            car = configuration.Container.GetInstance<ICar>();
        }

        public IBuilder SetBody(Bodies body)
        {
            car.Body = body;
            return this;
        }

        public IBuilder SetColour(Colours color)
        {
            car.Colour = color;
            return this;
        }

        public IBuilder SetEngine(Engines engine)
        {
            car.Engine = engine;
            return this;
        }

        public IBuilder SetGearBox(GearBoxes gearBox)
        {
            car.GearBox = gearBox;
            return this;
        }

        public IBuilder SetOptions(List<Options> options)
        {
            car.Options = new List<Options>();
            foreach (var item in options)
            {
                car.Options.Add(item);
            }
            return this;
        }
        public ICar Build()
        {
            return car;
        }
    }
}
