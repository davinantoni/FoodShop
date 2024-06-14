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
    public partial class UpdateMenuType : System.Web.UI.Page
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
                        MenuType type = MenuTypeController.GetMenuTypeByID(Id);
                        nameTB.Text = type.MenuTypeName;
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
            String name = nameTB.Text;
            int Id = int.Parse(Request.QueryString["id"]);

            string errorMsg = MenuTypeController.validateUpdate(name);

            if (errorMsg == "Update MenuType Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                MenuTypeController.updateMenuType(Id, name);
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