using FoodShop.Controller;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FoodShop.Views
{
    public partial class InsertMenu : System.Web.UI.Page
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
                        MenuTypeDD.DataSource = MenuTypeController.getAllMenuTypeName();
                        MenuTypeDD.DataBind();

                        RestaurantDD.DataSource = RestoController.getAllRestaurantName();
                        RestaurantDD.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            String menuName = NameTB.Text;
            int menuPrice = int.Parse(PriceTB.Text);
            int typeID = MenuTypeController.getMenuTypeIDByName(MenuTypeDD.SelectedValue);
            System.Diagnostics.Debug.WriteLine($"Selected Type Name: {MenuTypeDD.SelectedValue}, Type ID: {typeID}");
            int restoID = RestoController.getRestaurantIDByName(RestaurantDD.SelectedValue);
            string errorMsg = MenuController.registMenu(menuName, menuPrice, typeID, restoID);

            if (errorMsg == "Insert Menu Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                MenuController.insertMenu(menuName, menuPrice, typeID, restoID);
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