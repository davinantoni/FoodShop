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
    public partial class UpdateRestaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                    if (user.UserRole == "Customer")
                    {
                        Response.Redirect("~/Views/Home.aspx");
                    }
                    else
                    {
                        int Id = int.Parse(Request.QueryString["id"]);
                        Restaurant resto = RestoController.GetRestaurantByID(Id);
                        nameTB.Text = resto.RestaurantName;
                        ratingTB.Text = resto.RestaurantRating.ToString();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["id"]);
            String name = nameTB.Text;
            String rating = ratingTB.Text;
            int temp = Int32.Parse(rating);

            string errorMsg = RestoController.validateUpdate(name, temp);

            if (errorMsg == "Update Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                RestoController.updateRestaurants(Id, name, temp);
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }

        }
        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageFood.aspx");
        }
    }
}