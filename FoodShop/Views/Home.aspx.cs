using FoodShop.Controller;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            if (user == null && Request.Cookies["user_cookies"] != null)
            {
                // Mendapatkan user berdasarkan cookies
                string username = Request.Cookies["user_cookies"].Value;
                user = UserController.getUserByName(username);
                Session["user"] = user;
            }
            if (user != null)
            {
                UserRoleLabel.Text = "User Role: " + user.UserRole;
                UserNameLabel.Text = "User Name: " + user.Username;

                if (user.UserRole == "Admin")
                {
                    List<User> customerUsers = UserController.getCustomerList();

                    CustomerGV.DataSource = customerUsers;
                    CustomerGV.DataBind();
                }
                else
                {
                    CustomerGV.Visible = false;
                }
            }
            else
            {
                Response.Redirect("~/Views/Login.aspx");
            }
        }
    }
}