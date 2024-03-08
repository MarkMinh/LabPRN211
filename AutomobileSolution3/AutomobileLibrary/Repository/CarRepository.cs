using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        CarDAO carDAO = CarDAO.Instance;    
        public void DeleteCar(int carId)
        => carDAO.Remove(carId);

        public Car GetCarByID(int carId)
        => carDAO.GetCarByID(carId);

        public IEnumerable<Car> GetCars()
        => carDAO.GetCarList();

        public void InsertCar(Car car)
        => carDAO.AddNew(car);

        public void UpdateCar(Car car)
        => carDAO.Update(car);
    }
}
