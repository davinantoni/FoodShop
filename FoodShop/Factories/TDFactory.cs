using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class TDFactory
    {
        public static TransactionDetail Create(int tranID, int menuID, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = tranID;
            td.MenuID = menuID;
            td.Quantity = quantity;
            return td;
        }
    }
}