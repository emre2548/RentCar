using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if (car.Description.Length > 1 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Message.CarAdded);
            }
            else
            {
                if (car.Description.Length < 2)
                {
                    return new ErrorResult(Message.CarNameInvalid);
                }
                if (car.DailyPrice < 1)
                {
                    return new ErrorResult(Message.CarNameInvalid);
                }
                return new Result(false);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdate);
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
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice == dailyPrice));
        }

        public IDataResult<List<Car>> GetModelYear(int modelYear)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ModelYear == modelYear));
        }
        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
        }
    }
}
