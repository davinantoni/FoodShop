using FoodShop.Factories;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Repositories
{
    public class CartRepository
    {
        private static FoodShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Cart> getAllCarts()
        {
            return (from x in db.Carts select x).ToList();
        }

        public static int getLastCartID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }
        public static List<Cart> getCartByMenuID(int ID)
        {
            return (from x in db.Carts where x.MenuID == ID select x).ToList();
        }

        public static int generateCartID()
        {
            int lastID = getLastCartID();

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

        public static void addToCart(int userID, int makeupID, int quantity)
        {
            int cartID = generateCartID();
            Cart cart = CartFactory.Create(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static void clearCart(int userID)
        {
            //Cart cart = db.Carts.Find(userID);
            List<Cart> cartItems = db.Carts.Where(c => c.UserID == userID).ToList();
            db.Carts.RemoveRange(cartItems);
            db.SaveChanges();
        }

        public static int generateTransactionID()
        {
            int lastID = THRepository.getLastTransactionID();

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

        public static void checkout(int userID)
        {
            //Ngambil semua cart si user, karena 1 user bisa punya banyak cart
            List<Cart> userCarts = db.Carts.Where(c => c.UserID == userID).ToList();

            //Masukin ke Transaction Header
            TransactionHeader th = THFactory.Create(generateTransactionID(), userID, DateTime.Now, "Unhandled");
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

            //Ini masukin semua item dari setiap cart ke Transaction Details
            foreach (var cart in userCarts)
            {
                // Cari makeup berdasarkan MakeupID
                Menu menu = db.Menus.Find(cart.MenuID);
                if (menu != null)
                {
                    // Cari TransactionDetail yang sudah ada
                    TransactionDetail existingTD = TDRepository.getExistedTD(th.TransactionID, cart.MenuID);

                    if (existingTD != null)
                    {
                        // Update quantity yang sudah ada
                        existingTD.Quantity += cart.Quantity;
                    }
                    else
                    {
                        // Buat TransactionDetail baru jika tidak ada duplikat
                        TransactionDetail td = TDFactory.Create(th.TransactionID, menu.MenuID, cart.Quantity);
                        db.TransactionDetails.Add(td);
                    }
                }
            }
            //db.SaveChanges();
            db.Carts.RemoveRange(userCarts);
            db.SaveChanges();
        }
    }
}