using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            this._colorDal = colorDal;
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int ColorId)
        {
            return _colorDal.Get(c => c.Id == ColorId);
        }

        public void Insert(Color color)
        {
            _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
