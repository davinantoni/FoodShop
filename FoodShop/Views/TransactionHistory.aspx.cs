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
    public partial class TransactionHistory : System.Web.UI.Page
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
                        List<TransactionHeader> list = THController.getAllTransactionHeaderByUserID(user.UserID);
                        TransactionGV.DataSource = list;
                        TransactionGV.DataBind();
                        TransactionGV.Columns[1].Visible = false; // No need to see UserID
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

        protected void DetailButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int TransactionID = int.Parse(btn.CommandArgument);

            Response.Redirect("~/Views/TransactionDetails.aspx?id=" + TransactionID);
        }
    }
}