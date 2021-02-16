using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByBrandId()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByDailyPrice()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetModelYear()
        {
            throw new NotImplementedException();
        }
    }
}
