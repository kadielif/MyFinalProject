using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string ProductAddded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistemde bakım var";
        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bu kategoriye daha fazla ürün eklenemez";
        public static string ProductNameAlreadyExists="Bu üründen sistemde var";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
