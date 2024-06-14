using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class TDRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return (from x in db.TransactionDetails where x.TransactionID == ID select x).ToList();
        }

        public static List<TransactionDetail> getTransactionDetailByMenuID(int ID)
        {
            return (from x in db.TransactionDetails where x.MenuID == ID select x).ToList();
        }

        public static TransactionDetail getExistedTD(int transactionID, int menuID)
        {
            return db.TransactionDetails.FirstOrDefault(td => td.TransactionID == transactionID && td.MenuID == menuID);
        }
    }
}