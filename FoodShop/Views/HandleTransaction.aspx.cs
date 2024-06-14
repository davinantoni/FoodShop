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
    public partial class HandleTransaction : System.Web.UI.Page
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
                    else // ADMIN
                    {
                        List<TransactionHeader> list = THController.getAllTransactionHeader();
                        TransactionGV.DataSource = list;
                        TransactionGV.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void HandleButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int TransactionID = int.Parse(btn.CommandArgument);
            THController.handleTransaction(TransactionID);

            List<TransactionHeader> list = THController.getAllTransactionHeader();
            TransactionGV.DataSource = list;
            TransactionGV.DataBind();
        }
    }
}