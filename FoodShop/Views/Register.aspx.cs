using FoodShop.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            String username = nameTB.Text;
            String email = emailTB.Text;
            String gender = genderList.SelectedValue;
            String password = passwordTB.Text;
            String confirmPassword = confirmTB.Text;
            DateTime DOB = dobCalendar.SelectedDate;
            string errorMsg = UserController.Register(username, email, gender, password, confirmPassword, DOB);

            if (errorMsg == "Register Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                UserController.insertUser(username, email, DOB, gender, password);
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}