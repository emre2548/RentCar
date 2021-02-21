using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public class Message
    {
        public static string CarAdded = "Araç Eklendi.";
        public static string CarInvalidDailyPrice = "Günlük ücret sıfırdan büyük olmalıdır.";
        public static string CarAddedDailyPrice = "Günlük ücret eklendi.";
        public static string CarListed = "Araçlar listelendi.";
        public static string CarDetailListed = "Araç detayları listelendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarNameInvalid = "Araç adı 2 karekterde uzun olmalu.";
        public static string CarUpdate = "Araç güncellendi.";

        public static string BrandAdded { get; internal set; }
        public static string BrandDeleted { get; internal set; }
        public static string BrandUpdated { get; internal set; }
        public static string BrandListed { get; internal set; }
        public static string BrandListedById { get; internal set; }
        public static string ColorAdded { get; internal set; }
        public static string ColorDeleted { get; internal set; }
        public static string ColorUpdate { get; internal set; }
        public static string ColorsListed { get; internal set; }
        public static string CustomerAdded { get; internal set; }
        public static string CustomerDeleted { get; internal set; }
        public static string CustomerUpdated { get; internal set; }
        public static string CustomerListed { get; internal set; }
        public static string CustomerListedById { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string RentalDeleted { get; internal set; }
        public static string RentalUpdated { get; internal set; }
        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string UserListed { get; internal set; }
        public static string UserListedById { get; internal set; }
    }
}
