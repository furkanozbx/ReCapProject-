using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IServiceBase<T>
    {
        IResult Insert(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int ID);
    }
}
