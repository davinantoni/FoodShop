using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class UserFactory
    {
        public static User Create(int UserID, String name, String email, DateTime dob, String gender, String role,
                                    String pw)
        {
            User user = new User();
            user.UserID = UserID;
            user.Username = name;
            user.UserEmail = email;
            user.UserDOB = dob;
            user.UserGender = gender;
            user.UserRole = role;
            user.UserPassword = pw;
            return user;
        }
    }
}