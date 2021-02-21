using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDTO> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext contex = new CarRentalContext())
            {
                var result = from r in filter == null ? contex.Rentals : contex.Rentals.Where(filter)
                             join c in contex.Cars
                             on r.CarId equals c.Id
                             join cu in contex.Customers
                             on r.CustomerId equals cu.Id
                             join u in contex.Users
                             on cu.Id equals u.Id
                             select new RentalDetailDTO
                             {
                                 Id = r.Id,
                                 CarId = r.CarId,
                                 UserName = u.FirstName,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
