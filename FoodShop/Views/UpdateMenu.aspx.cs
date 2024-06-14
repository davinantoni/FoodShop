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
    public partial class UpdateMenu : System.Web.UI.Page
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
                        Model.Menu menu = MenuController.GetMenuByID(Id);
                        NameTB.Text = menu.MenuName;
                        PriceTB.Text = menu.MenuPrice.ToString();
                        MenuTypeDD.DataSource = MenuTypeController.getAllMenuTypeName();
                        MenuTypeDD.DataBind();

                        RestaurantDD.DataSource = RestoController.getAllRestaurantName();
                        RestaurantDD.DataBind();

                        MenuTypeDD.SelectedValue = menu.MenuTypeID.ToString();
                        RestaurantDD.SelectedValue = menu.RestaurantID.ToString();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(Request.QueryString["id"]);
            String name = NameTB.Text;
            int price = int.Parse(PriceTB.Text);
            int typeID = MenuTypeController.getMenuTypeIDByName(MenuTypeDD.SelectedValue);
            int restoID = RestoController.getRestaurantIDByName(RestaurantDD.SelectedValue);
            string errorMsg = MenuController.validateUpdate(name, price, typeID, restoID);
            if (errorMsg == "Update Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                MenuController.UpdateMenuByID(updateID, name, price, typeID, restoID);
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageFood.aspx");
        }
    }
}