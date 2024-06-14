using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class RestoController
    {
        public static List<Restaurant> getAllRestaurants()
        {
            return RestoHandler.getAllRestaurants();
        }

        public static int getRestaurantIDByName(String name)
        {
            return RestoHandler.getRestaurantIDByName(name);
        }

        public static void RemoveRestaurantById(int id)
        {
            RestoHandler.RemoveRestaurantById(id);
        }

        public static Restaurant GetRestaurantByID(int id)
        {
            return RestoHandler.GetRestaurantByID(id);
        }

        public static List<int> getAllRestaurantID()
        {
            return RestoHandler.getAllRestaurantID();
        }

        public static List<String> getAllRestaurantName()
        {
            return RestoHandler.getAllRestaurantName();
        }

        public static int getLastRestaurantID()
        {
            return RestoHandler.getLastRestaurantID();
        }
        public static void insertRestaurant(String name, int rating)
        {
            RestoHandler.insertRestaurant(name, rating);
        }

        public static void updateRestaurants(int id, String name, int rating)
        {
            RestoHandler.updateRestaurants(id, name, rating);
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

        public static string ValidateRating(int rating)
        {
            string lbl = "";

            if (rating < 0 || rating > 100)
            {
                lbl = "Rating must be between 0 - 100 <br/>";
            }

            return lbl;
        }

        public static string registRestaurant(string name, int rating)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidateRating(rating);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Insert Restaurant Successful!";
        }

        public static string validateUpdate(string name, int rating)
        {
            string lbl = "";
            lbl += ValidateName(name);
            lbl += ValidateRating(rating);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Successful!";
        }
    }
}