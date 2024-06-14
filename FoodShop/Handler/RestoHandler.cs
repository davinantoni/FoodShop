using FoodShop.Factories;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class RestoHandler
    {
        public static List<Restaurant> getAllRestaurants()
        {
            return RestaurantRepository.getAllRestaurants();
        }

        public static int getRestaurantIDByName(String name)
        {
            return RestaurantRepository.getRestaurantIDByName(name);
        }

        public static void RemoveRestaurantById(int id)
        {
            RestaurantRepository.RemoveRestaurantById(id);
        }

        public static Restaurant GetRestaurantByID(int id)
        {
            return RestaurantRepository.GetRestaurantByID(id);
        }

        public static List<int> getAllRestaurantID()
        {
            return RestaurantRepository.getAllRestaurantID();
        }

        public static List<String> getAllRestaurantName()
        {
            return RestaurantRepository.getAllRestaurantName();
        }

        public static int getLastRestaurantID()
        {
            return RestaurantRepository.getLastRestaurantID();
        }
        public static void insertRestaurant(String name, int rating)
        {
            RestaurantRepository.insertRestaurant(name, rating);
        }

        public static void updateRestaurants(int id, String name, int rating)
        {
            RestaurantRepository.updateRestaurants(id, name, rating);
        }
    }
}