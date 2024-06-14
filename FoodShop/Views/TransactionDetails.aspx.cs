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
    public partial class TransactionDetails : System.Web.UI.Page
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
                    int TransactionID = Convert.ToInt32(Request.QueryString["id"]);
                    List<TransactionDetail> listTD = TDController.getTransactionDetailByID(TransactionID);
                    TransactionDetailGV.DataSource = listTD;
                    TransactionDetailGV.DataBind();
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
    }
}