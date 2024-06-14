using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class TDController
    {
        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return TDHandler.getTransactionDetailByID(ID);
        }

        public static List<TransactionDetail> getTransactionDetailByMenuID(int ID)
        {
            return TDHandler.getTransactionDetailByMenuID(ID);
        }

        public static TransactionDetail getExistedTD(int transactionID, int menuID)
        {
            return TDHandler.getExistedTD(transactionID, menuID);
        }
    }
}