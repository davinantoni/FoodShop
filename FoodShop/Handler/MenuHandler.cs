using FoodShop.Factories;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class MenuHandler
    {
        public static List<Menu> getAllMenus()
        {
            return MenuRepository.getAllMenus();
        }

        public static int getMenuPrice(int id)
        {
            return MenuRepository.getMenuPrice(id);
        }

        public static int getMenuIDByName(String name)
        {
            return MenuRepository.getMenuIDByName(name);
        }

        public static void RemoveMenuById(int id)
        {
            MenuRepository.RemoveMenuById(id);
        }

        public static Menu GetMenuByID(int id)
        {
            return MenuRepository.GetMenuByID(id);
        }

        public static List<Menu> GetMenuByTypeID(int typeID)
        {
            return MenuRepository.GetMenuByTypeID(typeID);
        }

        public static List<Menu> GetMenuByRestoID(int restoID)
        {
            return MenuRepository.GetMenuByRestoID(restoID);
        }

        public static void UpdateMenuByID(int id, String name, int price, int menuTypeID, int restoID)
        {
            MenuRepository.UpdateMenuByID(id, name, price, menuTypeID, restoID);
        }

        public static int getLastMenuID()
        {
            return MenuRepository.getLastMenuID();
        }

        public static void insertMenu(String name, int price, int typeID, int restoID)
        {
            MenuRepository.insertMenu(name, price, typeID, restoID);
        }
    }
}