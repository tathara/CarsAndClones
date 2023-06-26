namespace CarsAndClones.DI
{
    public interface ICarData<T>
    {
        void AddCar(ICar car);
        ICar FindCar(T car);
        IEnumerable<T> GetAllCars();
        void RemoveCar(ICar car);
    }
}
