using FoodShop.Handler;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FoodShop.Controller
{
    public class UserController
    {
        public static string ValidateUsername(string username)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(username))
            {
                lbl = "Username cannot be empty  <br/>";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                lbl = "Username length must be between 5 and 15 characters <br/>";
            }
            else if (!UserHandler.IsUsernameUnique(username))
            {
                lbl = "Username must be unique <br/>";
            }
            return lbl;
        }

        public static string ValidateEmail(string email)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(email))
            {
                lbl = "Email cannot be empty <br/>";
            }
            else if (!email.EndsWith(".com"))
            {
                lbl = "Email must end with ‘.com’ <br/>";
            }
            return lbl;
        }

        public static string ValidateGender(string gender)
        {
            string lbl = "";
            if (gender == "")
            {
                lbl = "Gender Must be chosen and cannot be empty <br/>";
            }
            return lbl;
        }

        public static string ValidatePassword(string password, string confirmPassword)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(password))
            {
                lbl = "Password cannot be empty <br/>";
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                lbl = "Confirm password cannot be empty <br/>";
            }
            else if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                lbl = "Password must be alphanumeric.<br/>";
            }
            else if (password != confirmPassword)
            {
                lbl = "Must be the same with confirm password <br/>";
            }
            return lbl;
        }

        public static string ValidateDOB(DateTime dob)
        {
            string lbl = "";
            if (dob == DateTime.MinValue)
            {
                lbl = "Date of Birth cannot be empty.";
            }
            return lbl;
        }

        public static User Login(String username, String password, out string lbl)
        {
            lbl = "";
            if (string.IsNullOrEmpty(username))
            {
                lbl += "Username cannot be empty<br/>";
            }

            if (string.IsNullOrEmpty(password))
            {
                lbl += "Password cannot be empty<br/>";
            }

            if (!string.IsNullOrEmpty(lbl))
            {
                return null;
            }

            User user = UserHandler.GetUserByNameAndPassword(username, password);
            if (user == null)
            {
                lbl = "Invalid username or password";
            }

            return user;
        }

        public static void insertUser(string username, string email, DateTime dob, string gender, string password)
        {
            UserHandler.insertUser(username, email, dob, gender, password);
        }

        public static User getUserById(int id)
        {
            return UserHandler.getUserById(id);
        }

        public static User getUserByName(string username)
        {
            return UserHandler.getUserByName(username);
        }

        public static List<User> getCustomerList()
        {
            return UserHandler.getCustomerList();
        }

        public static string Register(string username, string email, string gender, string password, string confirmPassword, DateTime dob)
        {
            string lbl = "";
            lbl += ValidateUsername(username);
            lbl += ValidateEmail(email);
            lbl += ValidateGender(gender);
            lbl += ValidatePassword(password, confirmPassword);
            lbl += ValidateDOB(dob);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Register Successful!";
        }

        public static string validateProfile(string username, string email, string gender, DateTime dob)
        {
            string lbl = "";
            lbl += ValidateUsername(username);
            lbl += ValidateEmail(email);
            lbl += ValidateGender(gender);
            lbl += ValidateDOB(dob);

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Profile Successful!";
        }

        public static void updateUser(int userId, String name, String email, String gender, DateTime dob)
        {
            UserHandler.updateUser(userId, name, email, gender, dob);
        }

        public static string validateChangePw(int userID, String oldPassword, String newPassword)
        {
            string lbl = "";
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                lbl = "Passwords cannot be empty.";
            }

            if (string.IsNullOrEmpty(lbl))
            {
                User user = getUserById(userID);
                if (user.UserPassword != oldPassword)
                {
                    lbl = "Old password is incorrect.<br/>";
                }
            }

            if (!string.IsNullOrEmpty(lbl))
            {
                return lbl;
            }
            return "Update Password Successful!";
        }

        public static void updateUserPassword(int userId, String newPW)
        {
            UserHandler.updateUserPassword(userId, newPW);
        }
    }
}