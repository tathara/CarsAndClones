using CarsAndClones.DI;
using CarsAndClones.Bll;
using CarsAndClones.Data;
using SimpleInjector;

namespace CarsAndClones.Settings
{
    public class Configuration
    {
        public Container Container { get; }

        public Configuration()
        {
            Container = new Container();

            Setup();
        }

        public virtual void Setup()
        {
            Container.Register<ICar, Car>(Lifestyle.Transient);
            Container.Register<ICarData<ICar>, CarData>(Lifestyle.Singleton);
            Container.Register<ICarFactory, CarFactory>(Lifestyle.Singleton);
        }
    }
}