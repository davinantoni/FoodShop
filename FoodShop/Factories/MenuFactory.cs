using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class MenuFactory
    {
        public static Menu Create(int id, String name, int price, int menuTypeID, int restaurantID)
        {
            Menu menu = new Menu();
            menu.MenuID = id;
            menu.MenuName = name;
            menu.MenuPrice = price;
            menu.MenuTypeID = menuTypeID;
            menu.RestaurantID = restaurantID;
            return menu;
        }
    }
}