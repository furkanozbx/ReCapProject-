using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=345,DailyPrice=350000,ModelYear=new DateTime(2020),Description="Lada Samara || Fişşek gibi araba"},
                new Car{Id=1,BrandId=4,ColorId=25,DailyPrice=350000,ModelYear=new DateTime(2008),Description="Volvo || Yeni Kasa"},
                new Car{Id=1,BrandId=56,ColorId=15,DailyPrice=350000,ModelYear=new DateTime(2003),Description="Fiat Punda || Sahibinden satılık"},
                new Car{Id=1,BrandId=2,ColorId=38,DailyPrice=350000,ModelYear=new DateTime(2015),Description="Doblo || Öğretmenden satılık"},
                new Car{Id=1,BrandId=4,ColorId=35,DailyPrice=350000,ModelYear=new DateTime(2012),Description="Pegout || Yeni gibi Pert Araba"},
                new Car{Id=1,BrandId=7,ColorId=825,DailyPrice=350000,ModelYear=new DateTime(1921),Description="Ford || 100 yıllık ama yeni gibi"}
                
            };
        }

        public void Add(Car entity)
        {
                _cars.Add(entity);    
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).FirstOrDefault();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.FirstOrDefault(p => p.Id == entity.Id);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
