using FoodShop.Factories;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class MenuTypeRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<MenuType> getAllMenuTypes()
        {
            return (from x in db.MenuTypes select x).ToList();
        }

        public static int getMenuTypeIDByName(String name)
        {
            return (from x in db.MenuTypes where x.MenuTypeName == name select x.MenuTypeID).FirstOrDefault();
        }

        public static void RemoveMenuTypeById(int id)
        {
            //Kalo kita hapus typeID 1, beraarti menu yang punya id 1 juga ikut kehapus
            MenuType type = db.MenuTypes.Find(id);
            List<Menu> menu = MenuRepository.GetMenuByTypeID(id);
            db.Menus.RemoveRange(menu);
            db.MenuTypes.Remove(type);
            db.SaveChanges();
        }

        public static MenuType GetMenuTypeByID(int id)
        {
            MenuType type = db.MenuTypes.Find(id);
            return type;
        }

        public static List<int> getAllMenuTypeID()
        {
            return (from x in db.MenuTypes select x.MenuTypeID).ToList();
        }

        public static List<String> getAllMenuTypeName()
        {
            return (from x in db.MenuTypes select x.MenuTypeName).ToList();
        }

        public static int getLastMenuTypeID()
        {
            return (from x in db.MenuTypes select x.MenuTypeID).ToList().LastOrDefault();
        }
        public static int generateMenuTypeID()
        {
            int lastID = getLastMenuTypeID();

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

        public static void insertMenuType(String name)
        {
            int MenuTypeID = generateMenuTypeID();
            MenuType type = MenuTypeFactory.Create(MenuTypeID, name);
            db.MenuTypes.Add(type);
            db.SaveChanges();
        }

        public static void updateMenuType(int id, String name)
        {
            MenuType updateType = db.MenuTypes.Find(id);
            updateType.MenuTypeName = name;

            db.SaveChanges();
        }
    }
}