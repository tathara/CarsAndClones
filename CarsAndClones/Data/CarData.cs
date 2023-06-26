using CarsAndClones.DI;
using CarsAndClones.Enums;

namespace CarsAndClones.Data
{
    class CarData : ICarData<ICar>
    {
        public void AddCar(ICar car)
        {
            using (var database = new DatabaseContext())
            {
                var carToAdd = new CarEntity(car);
                database.Cars.Add(carToAdd);
                database.SaveChanges();
            }
        }

        public IEnumerable<ICar> GetAllCars()
        {
            using(var database = new DatabaseContext())
            {
                foreach (var car in database.Cars.ToList())
                {
                    car.Options = GetCarOptions(car);
                }
                return database.Cars.ToList();
            }
        }

        public void RemoveCar(ICar car)
        {
            using(var database = new DatabaseContext())
            {
                ICar carToRemove = FindCar(car);
                database.Cars.Remove((CarEntity)carToRemove);
                database.SaveChanges();
            }
        }

        public ICar FindCar(ICar car)
        {
            using (var database = new DatabaseContext())
            {
                EnumHandler enumHandler = new EnumHandler();
                string options = "";
                for (int i = 0; i < car.Options.Count(); i++)
                {
                    options += ((int)car.Options[i]).ToString();
                    if (car.Options.Count() > 1 && i + 1 < car.Options.Count()) options += ", ";
                }

                ICar foundCar = database.Cars.First(x => x.Model.Equals(car.Model) && x.Body.Equals(car.Body)
                && x.Colour.Equals(car.Colour) && x.Engine.Equals(car.Engine) && x.GearBox.Equals(car.GearBox) && x.OptionsString.Equals(options));
                return foundCar;
            }
        }

        private List<Options> GetCarOptions(ICar car)
        {
            using(var database = new DatabaseContext())
            {
                Options[] optionsArray;
                optionsArray = (Options[])Enum.GetValues(typeof(Options));
                CarEntity carEntity = database.Cars.First(x => x == car);
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
}
