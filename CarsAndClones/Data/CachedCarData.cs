using CarsAndClones.DI;
using CarsAndClones.Enums;

namespace CarsAndClones.Data
{
    public class CachedCarData : ICarData<ICar>
    {
        private readonly ICarData<ICar> carData;
        private List<ICar> cache;

        public CachedCarData(ICarData<ICar> data)
        {
            carData = data;
            UpdateCache();
        }

        public IEnumerable<ICar> GetAllCars()
        {
            foreach (var car in cache)
            {
                car.Options = GetCarOptions(car);
            }
            return cache != null ? cache : carData.GetAllCars();
        }

        public ICar FindCar(ICar car)
        {
            ICar foundCar = cache.FirstOrDefault(x => x.Model.Equals(car.Model) && x.Colour.Equals(car.Colour)
            && x.Engine.Equals(car.Engine) && x.GearBox.Equals(car.GearBox)
            && (x.Options.SequenceEqual(car.Options) || x.Options.Equals(car.Options)));
            if (foundCar == null) UpdateCache();
            return foundCar != null ? foundCar : carData.FindCar(car);
        }

        public void AddCar(ICar car)
        {
            cache.Add(car);
            carData.AddCar(car);
        }

        public void RemoveCar(ICar car)
        {
            cache.Remove(FindCar(car));
            carData.RemoveCar(car);
        }

        private void UpdateCache()
        {
            cache = carData.GetAllCars().ToList();
        }

        private List<Options> GetCarOptions(ICar car)
        {
            Options[] optionsArray;
            optionsArray = (Options[])Enum.GetValues(typeof(Options));
            CarEntity carEntity = (CarEntity)cache.First(x => x == car);
            carEntity.Options = new List<Options>();
            string[] options = carEntity.OptionsString.Split(", ");
            for (int i = 0; i < options.Count(); i++)
            {
                carEntity.Options.Add(optionsArray[Convert.ToInt32(options[i]) - 1]);
            }
            return carEntity.Options;
        }
    }
}
