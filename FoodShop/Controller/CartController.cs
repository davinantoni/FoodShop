using FoodShop.Handler;
using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Controller
{
    public class CartController
    {
        public static List<Cart> getAllCarts()
        {
            return CartHandler.getAllCarts();
        }

        public static void addToCart(int userID, int makeupID, int quantity)
        {
            CartHandler.addToCart(userID, makeupID, quantity);
        }

        public static List<Cart> getCartByMenuID(int ID)
        {
            return CartHandler.getCartByMenuID(ID);
        }

        public static void clearCart(int userID)
        {
            CartHandler.clearCart(userID);
        }

        public static void checkout(int userID)
        {
            CartHandler.checkout(userID);
        }
    }
}