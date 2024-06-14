using FoodShop.Factories;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class RestaurantRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Restaurant> getAllRestaurants()
        {
            return (from x in db.Restaurants
                    orderby x.RestaurantRating descending
                    select x).ToList();
        }

        public static int getRestaurantIDByName(String name)
        {
            return (from x in db.Restaurants
                    where x.RestaurantName == name
                    select x.RestaurantID).FirstOrDefault();
        }

        public static void RemoveRestaurantById(int id)
        {
            Restaurant resto = db.Restaurants.Find(id);
            List<Menu> menu = MenuRepository.GetMenuByRestoID(id);
            db.Menus.RemoveRange(menu);
            db.Restaurants.Remove(resto);
            db.SaveChanges();
        }

        public static Restaurant GetRestaurantByID(int id)
        {
            Restaurant resto = db.Restaurants.Find(id);
            return resto;
        }

        public static List<int> getAllRestaurantID()
        {
            return (from x in db.Restaurants select x.RestaurantID).ToList();
        }

        public static List<String> getAllRestaurantName()
        {
            return (from x in db.Restaurants select x.RestaurantName).ToList();
        }

        public static int getLastRestaurantID()
        {
            return (from x in db.Restaurants select x.RestaurantID).ToList().LastOrDefault();
        }
        public static int generateRestaurantID()
        {
            int lastID = getLastRestaurantID();

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
        public static void insertRestaurant(String name, int rating)
        {
            int RestaurantdID = generateRestaurantID();
            Restaurant resto = RestaurantFactory.Create(RestaurantdID, name, rating);
            db.Restaurants.Add(resto);
            db.SaveChanges();
        }

        public static void updateRestaurants(int id, String name, int rating)
        {
            Restaurant updateResto = db.Restaurants.Find(id);
            updateResto.RestaurantName = name;
            updateResto.RestaurantRating = rating;

            db.SaveChanges();
        }
    }
}