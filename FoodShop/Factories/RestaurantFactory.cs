using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class RestaurantFactory
    {
        public static Restaurant Create(int id, String name, int rating)
        {
            Restaurant resto = new Restaurant();
            resto.RestaurantID = id;
            resto.RestaurantName = name;
            resto.RestaurantRating = rating;
            return resto;
        }
    }
}