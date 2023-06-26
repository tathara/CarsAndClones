using CarsAndClones.DI;
using CarsAndClones.Data;

namespace CarsAndClones.Bll
{
    public class CarFactory : ICarFactory
    {
        private readonly ICarData<ICar> cachedCarData;

        public CarFactory(ICarData<ICar> data)
        {
            cachedCarData = new CachedCarData(data);
        }

        public void AddCarToDb(ICar car)
        {
            cachedCarData.AddCar(car);
        }

        public ICar FindCarInDb(ICar car)
        {
            return cachedCarData.FindCar(car);
        }

        public void RemoveCarFromDb(ICar car)
        {
            cachedCarData.RemoveCar(car);
        }

        public IEnumerable<ICar> GetAllCars()
        {
            return cachedCarData.GetAllCars();
        }
    }
}
