using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class CartFactory
    {
        public static Cart Create(int cartID, int userID, int menuID, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartID;
            cart.UserID = userID;
            cart.MenuID = menuID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}