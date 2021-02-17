using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal dailyPrice);
        IDataResult<List<Car>> GetModelYear(int modelYear);
    }
}
