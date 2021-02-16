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
        IDataResult<List<Car>> GetAllByBrandId();
        IDataResult<List<Car>> GetByDailyPrice();
        IDataResult<List<Car>> GetModelYear();
    }
}
