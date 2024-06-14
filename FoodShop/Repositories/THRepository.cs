using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class THRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static int getLastTransactionID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }

        public static List<TransactionHeader> getAllTransactionHeaderByUserID(int UserID)
        {
            return (from x in db.TransactionHeaders where x.UserID == UserID select x).ToList();
        }


        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public static void handleTransaction(int TransactionID)
        {
            TransactionHeader th = db.TransactionHeaders.Find(TransactionID);

            if (th != null && th.Status.Equals("Unhandled"))
            {
                th.Status = "Handled";
                db.SaveChanges();
            }
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return (from t in db.TransactionHeaders select t).ToList();
        }
    }
}