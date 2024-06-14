using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class THFactory
    {
        public static TransactionHeader Create(int tranID, int userID, DateTime date, String status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.TransactionID = tranID;
            transactionHeader.UserID = userID;
            transactionHeader.TransactionDate = date;
            transactionHeader.Status = status;
            return transactionHeader;
        }
    }
}