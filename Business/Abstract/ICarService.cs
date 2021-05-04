using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Insert(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetById(int CarId);
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
        List<CarDetailDto> GetCarDetails();
    }
}
