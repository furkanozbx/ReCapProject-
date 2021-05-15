using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this._rentalDal = rentalDal;
        }
        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new Result(true);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataResult<List<Rental>>(_rentalDal.GetAll(), true);
        }

        public IDataResult<Rental> GetById(int ID)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == ID));
        }

        public IResult Insert(Rental entity)
        {
            if (entity.ReturnDate !=null)
            {
                if (entity.ReturnDate < DateTime.Now)
                {
                    _rentalDal.Add(entity);
                    return new Result(true);
                }
                else
                {
                    return new Result(false,"ARAÇ şuanda kirada");
                }
            }
            else
            {
                return new Result(false, Messages.RentalError);
            }
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new Result(true);
        }
    }
}
