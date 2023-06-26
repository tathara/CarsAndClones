using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndClones.DI
{
    public interface ICarFactory
    {
        void AddCarToDb(ICar car);
        void RemoveCarFromDb(ICar car);
        ICar FindCarInDb(ICar car);
        IEnumerable<ICar> GetAllCars();
    }
}
