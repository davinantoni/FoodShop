using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class MenuController
    {
        public static List<Menu> getAllMenus()
        {
            return MenuHandler.getAllMenus();
        }

        public static int getMenuPrice(int id)
        {
            return MenuHandler.getMenuPrice(id);
        }

        public static int getMenuIDByName(String name)
        {
            return MenuHandler.getMenuIDByName(name);
        }

        public static void RemoveMenuById(int id)
        {
            MenuHandler.RemoveMenuById(id);
        }

        public static Menu GetMenuByID(int id)
        {
            return MenuHandler.GetMenuByID(id);
        }

        public static List<Menu> GetMenuByTypeID(int typeID)
        {
            return MenuHandler.GetMenuByTypeID(typeID);
        }

        public static List<Menu> GetMenuByRestoID(int restoID)
        {
            return MenuHandler.GetMenuByRestoID(restoID);
        }

        public static void UpdateMenuByID(int id, String name, int price, int menuTypeID, int restoID)
        {
            MenuHandler.UpdateMenuByID(id, name, price, menuTypeID, restoID);
        }

        public static int getLastMenuID()
        {
            return MenuHandler.getLastMenuID();
        }

        public static void insertMenu(String name, int price, int typeID, int restoID)
        {
            MenuHandler.insertMenu(name, price, typeID, restoID);
        }

        public static string ValidateName(string name)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(name))
            {
                lbl = "Name cannot be empty  <br/>";
            }
            else if (name.Length < 1 || name.Length > 99)
            {
                lbl = "Name length must be between 1 - 99 characters <br/>";
            }

            return lbl;
        }

        public static string ValidatePrice(int price)
        {
            string lbl = "";

            if (price < 1)
            {
                lbl = "Price must be greater than or equals than 1  <br/>";
            }

            return lbl;
        }

        public static string ValidateTypeID(int Typeid)
        {
            string lbl = "";
            if (Typeid == 0 || Typeid == null)
            {
                lbl = "TypeID cannot be empty <br/>";
            }

            return lbl;
        }

        public static string ValidateRestaurantID(int Brandid)
        {
            string lbl = "";
            if (Brandid == 0 || Brandid == null)
            {
                lbl = "RestaurantID cannot be empty <br/>";
            }

            return lbl;
        }

        public static string validateUpdate(string name, int price, int typeID, int restoID)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidatePrice(price);
            lbl += ValidateTypeID(typeID);
            lbl += ValidateRestaurantID(restoID);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Successful!";
        }

        public static string registMenu(string name, int price, int typeID, int restoID)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidatePrice(price);
            lbl += ValidateTypeID(typeID);
            lbl += ValidateRestaurantID(restoID);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert Menu Successful!";
        }
    }
}