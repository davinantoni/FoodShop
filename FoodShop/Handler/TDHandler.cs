using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class TDHandler
    {
        public static List<TransactionDetail> getTransactionDetailByID(int ID)
        {
            return TDRepository.getTransactionDetailByID(ID);
        }

        public static List<TransactionDetail> getTransactionDetailByMenuID(int ID)
        {
            return TDRepository.getTransactionDetailByMenuID(ID);
        }

        public static TransactionDetail getExistedTD(int transactionID, int menuID)
        {
            return TDRepository.getExistedTD(transactionID, menuID);
        }
    }
}