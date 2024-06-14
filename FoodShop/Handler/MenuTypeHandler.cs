using FoodShop.Factories;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class MenuTypeHandler
    {
        public static List<MenuType> getAllMenuTypes()
        {
            return MenuTypeRepository.getAllMenuTypes();
        }

        public static int getMenuTypeIDByName(String name)
        {
            return MenuTypeRepository.getMenuTypeIDByName(name);
        }

        public static void RemoveMenuTypeById(int id)
        {
            MenuTypeRepository.RemoveMenuTypeById(id);
        }

        public static MenuType GetMenuTypeByID(int id)
        {
            return MenuTypeRepository.GetMenuTypeByID(id);
        }

        public static List<int> getAllMenuTypeID()
        {
            return MenuTypeRepository.getAllMenuTypeID();
        }

        public static List<String> getAllMenuTypeName()
        {
            return MenuTypeRepository.getAllMenuTypeName();
        }

        public static int getLastMenuTypeID()
        {
            return MenuTypeRepository.getLastMenuTypeID();
        }

        public static void insertMenuType(String name)
        {
            MenuTypeRepository.insertMenuType(name);
        }

        public static void updateMenuType(int id, String name)
        {
            MenuTypeRepository.updateMenuType(id, name);
        }
    }
}