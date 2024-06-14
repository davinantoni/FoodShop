using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class DatabaseSingleton
    {
        private static FoodShopDatabaseEntities db = null;
        public static FoodShopDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new FoodShopDatabaseEntities();
            }
            return db;
        }
    }
}