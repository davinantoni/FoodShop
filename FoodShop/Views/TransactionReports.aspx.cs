using FoodShop.Controller;
using FoodShop.Dataset;
using FoodShop.Model;
using FoodShop.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop.Views
{
    public partial class TransactionReports : System.Web.UI.Page
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
                    if (user.UserRole == "Admin")
                    {
                        DataSet1 data = getData(THController.getAllTransaction());
                        CrystalReport1 report = new CrystalReport1();
                        CrystalReportViewer1.ReportSource = report;
                        report.SetDataSource(data);
                    }
                    else
                    {
                        Response.Redirect("~/Views/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }
        //C:\inetpub\wwwroot -> Copy ini, paste di directory this pc abis tu copy folder nya masukin ke vs 2022
        public DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            foreach (TransactionHeader t in transactions)
            {
                int subTotal = 0;
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;



                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MenuID"] = d.MenuID;
                    drow["Quantity"] = d.Quantity;

                    int menuPrice = MenuController.getMenuPrice(d.MenuID);
                    int totalPrice = d.Quantity * menuPrice;
                    drow["TotalPrice"] = totalPrice;
                    subTotal += totalPrice;

                    detailTable.Rows.Add(drow);
                }

                hrow["SubTotal"] = subTotal;
                headerTable.Rows.Add(hrow);
            }
            return data;
        }
    }
}