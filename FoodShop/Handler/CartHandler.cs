using FoodShop.Model;
using FoodShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Handler
{
    public class CartHandler
    {
        public static List<Cart> getAllCarts()
        {
            return CartRepository.getAllCarts();
        }

        public static void addToCart(int userID, int makeupID, int quantity)
        {
            CartRepository.addToCart(userID, makeupID, quantity);
        }

        public static List<Cart> getCartByMenuID(int ID)
        {
            return CartRepository.getCartByMenuID(ID);
        }

        public static void clearCart(int userID)
        {
            CartRepository.clearCart(userID);
        }

        public static void checkout(int userID)
        {
            CartRepository.checkout(userID);
        }
    }
}