using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class MenuTypeController
    {
        public static List<MenuType> getAllMenuTypes()
        {
            return MenuTypeHandler.getAllMenuTypes();
        }

        public static int getMenuTypeIDByName(String name)
        {
            return MenuTypeHandler.getMenuTypeIDByName(name);
        }

        public static void RemoveMenuTypeById(int id)
        {
            MenuTypeHandler.RemoveMenuTypeById(id);
        }

        public static MenuType GetMenuTypeByID(int id)
        {
            return MenuTypeHandler.GetMenuTypeByID(id);
        }

        public static List<int> getAllMenuTypeID()
        {
            return MenuTypeHandler.getAllMenuTypeID();
        }

        public static List<String> getAllMenuTypeName()
        {
            return MenuTypeHandler.getAllMenuTypeName();
        }

        public static int getLastMenuTypeID()
        {
            return MenuTypeHandler.getLastMenuTypeID();
        }

        public static void insertMenuType(String name)
        {
            MenuTypeHandler.insertMenuType(name);
        }

        public static void updateMenuType(int id, String name)
        {
            MenuTypeHandler.updateMenuType(id, name);
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
                lbl = "Name length must be between 1 and 99 characters <br/>";
            }

            return lbl;
        }


        public static string registMenuType(string name)
        {
            string lbl = "";
            lbl += ValidateName(name);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert MenuType Successful!";
        }

        public static string validateUpdate(string name)
        {
            string lbl = "";
            lbl += ValidateName(name);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update MenuType Successful!";
        }
    }
}