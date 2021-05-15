using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this._customerDal = customerDal;
        }
        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new Result(true);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int ID)
        {
            return new DataResult<Customer>(_customerDal.Get(c => c.UserId == ID),true);
        }

        public IResult Insert(Customer entity)
        {
            _customerDal.Add(entity);
            return new Result(true);
        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new Result(true);
        }
    }
}
