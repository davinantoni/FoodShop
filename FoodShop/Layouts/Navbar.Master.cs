using FoodShop.Controller;
using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop.Layouts
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookies"] == null)
            {
                Home.Visible = false;
                manageFood.Visible = false;
                orderQueue.Visible = false;
                transactionReport.Visible = false;
                orderFood.Visible = false;
                History.Visible = false;
                ProfileButton.Visible = false;
                Logout.Visible = false;
            }
            else
            {
                User user = new User();
                if (Session["user"] == null)
                {
                    String username = Request.Cookies["user_cookies"].Value;
                    user = UserController.getUserByName(username);
                    Session["user"] = user;
                }
                else
                {
                    user = (User)Session["User"];
                }
                if (user.UserRole == "Customer")
                {
                    // Home.Visible = false;
                    manageFood.Visible = false;
                    orderQueue.Visible = false;
                    transactionReport.Visible = false;
                }
                else if (user.UserRole == "Admin")
                {
                    orderFood.Visible = false;
                    //History.Visible = false;
                }
            }
        }

        protected void orderFood_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderFood.aspx");
        }

        protected void History_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistory.aspx");
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Profile.aspx");
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }

        protected void manageFood_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageFood.aspx");
        }

        protected void orderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HandleTransaction.aspx");
        }

        protected void transactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionReports.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session.Abandon();

            Response.Cookies["user_cookies"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("~/Views/Login.aspx");
        }
    }
}