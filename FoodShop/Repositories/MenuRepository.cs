using FoodShop.Factories;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class MenuRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Menu> getAllMenus()
        {
            return (from x in db.Menus orderby x.RestaurantID ascending select x).ToList();
        }

        public static int getMenuPrice(int id)
        {
            return (from x in db.Menus where x.MenuID == id select x.MenuPrice).FirstOrDefault();
        }

        public static int getMenuIDByName(String name)
        {
            return (from x in db.Menus where x.MenuName == name select x.MenuID).FirstOrDefault();
        }

        public static void RemoveMenuById(int id)
        {
            Menu menu = db.Menus.Find(id);
            List<Cart> cart = CartRepository.getCartByMenuID(id);
            db.Carts.RemoveRange(cart);
            List<TransactionDetail> td = TDRepository.getTransactionDetailByMenuID(id);
            db.TransactionDetails.RemoveRange(td);
            db.Menus.Remove(menu);
            db.SaveChanges();
        }

        public static Menu GetMenuByID(int id)
        {
            Menu menu = db.Menus.Find(id);
            return menu;
        }

        public static List<Menu> GetMenuByTypeID(int typeID)
        {
            List<Menu> menu = (from x in db.Menus where x.MenuTypeID == typeID select x).ToList();
            return menu;
        }

        public static List<Menu> GetMenuByRestoID(int restoID)
        {
            List<Menu> menu = (from x in db.Menus where x.RestaurantID == restoID select x).ToList();
            return menu;
        }

        public static void UpdateMenuByID(int id, String name, int price, int menuTypeID, int restoID)
        {
            Menu updateMenu = GetMenuByID(id);
            updateMenu.MenuName = name;
            updateMenu.MenuPrice = price;
            updateMenu.MenuTypeID = menuTypeID;
            updateMenu.RestaurantID = restoID;
            db.SaveChanges();
        }

        public static int getLastMenuID()
        {
            return (from x in db.Menus select x.MenuID).ToList().LastOrDefault();
        }

        public static int generateMenuID()
        {
            int lastID = getLastMenuID();

            if (lastID == null)
            {
                lastID = 1;
            }
            else
            {
                lastID++;
            }
            return lastID;
        }

        public static void insertMenu(String name, int price, int typeID, int restoID)
        {
            int menuID = generateMenuID();
            Menu menu = MenuFactory.Create(menuID, name, price, typeID, restoID);
            db.Menus.Add(menu);
            db.SaveChanges();
        }
    }
}