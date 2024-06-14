using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class THController
    {
        public static int getLastTransactionID()
        {
            return THHandler.getLastTransactionID();
        }

        public static List<TransactionHeader> getAllTransactionHeaderByUserID(int UserID)
        {
            return THHandler.getAllTransactionHeaderByUserID(UserID);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return THHandler.getAllTransactionHeader();
        }

        public static void handleTransaction(int TransactionID)
        {
            THHandler.handleTransaction(TransactionID);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return THHandler.getAllTransaction();
        }
    }
}