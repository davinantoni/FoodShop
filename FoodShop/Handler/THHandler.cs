using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class THHandler
    {
        public static int getLastTransactionID()
        {
            return THRepository.getLastTransactionID();
        }

        public static List<TransactionHeader> getAllTransactionHeaderByUserID(int UserID)
        {
            return THRepository.getAllTransactionHeaderByUserID(UserID);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return THRepository.getAllTransactionHeader();
        }

        public static void handleTransaction(int TransactionID)
        {
            THRepository.handleTransaction(TransactionID);
        }

        public static List<TransactionHeader> getAllTransaction()
        {
            return THRepository.getAllTransaction();
        }
    }
}