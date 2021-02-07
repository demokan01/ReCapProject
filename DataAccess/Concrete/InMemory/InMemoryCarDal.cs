using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=2,CarName="Polo",ColorId=3,ModelYear="2012",DailyPrice=150,Description="Benzin"},
                new Car{CarId=2,BrandId=1,CarName="Corsa",ColorId=3,ModelYear="2015",DailyPrice=170,Description="Dizel"},
                new Car{CarId=3,BrandId=3,CarName="Insignia",ColorId=3,ModelYear="2016",DailyPrice=200,Description="Benzin"},
                new Car{CarId=4,BrandId=4,CarName="Fiesta",ColorId=3,ModelYear="2017",DailyPrice=200,Description="Dizel"},
                new Car{CarId=5,BrandId=5,CarName="Linea",ColorId=3,ModelYear="2013",DailyPrice=160,Description="Dizel"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
