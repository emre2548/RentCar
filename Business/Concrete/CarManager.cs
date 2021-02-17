using Business.Abstract;
using Business.Constant;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0)
            {
                return new ErrorResult(Message.CarInvalidDailyPrice);
            }
            return new SuccessResult(Message.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Message.CarDetailListed);
        }

        public IDataResult<List<Car>> GetCarByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal dailyPrice)
        {
            return new SuccessDataResult<List<Car>(_carDal.GetAll(p => p.DailyPrice == dailyPrice));
        }

        public IDataResult<List<Car>> GetModelYear(int modelYear)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ModelYear == modelYear));
        }
    }
}
