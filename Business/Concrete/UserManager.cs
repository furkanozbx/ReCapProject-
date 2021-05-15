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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            this._userDal = userDal;
        }


        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new Result(true);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UserSListed);
        }

        public IDataResult<User> GetById(int ID)
        {
            return new DataResult<User>(_userDal.Get(u => u.Id == ID),true);
        }

        public IResult Insert(User entity)
        {
            _userDal.Add(entity);
            return new Result(true);
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new Result(true);
        }
    }
}
