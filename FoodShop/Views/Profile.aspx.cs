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
    public partial class Profile : System.Web.UI.Page
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
                    nameTB.Text = user.Username;
                    emailTB.Text = user.UserEmail;
                    genderList.SelectedValue = user.UserGender;
                    dobCalendar.SelectedDate = user.UserDOB;
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            string username = nameTB.Text;
            string email = emailTB.Text;
            string gender = genderList.SelectedValue;
            DateTime dob = dobCalendar.SelectedDate;

            string errorMsg = UserController.validateProfile(username, email, gender, dob);
            if (errorMsg == "Update Profile Successful!")
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Green;
                UserController.updateUser(user.UserID, username, email, gender, dob);
            }
            else
            {
                ErrorLbl.Text = errorMsg;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            string oldPassword = OldPasswordTB.Text;
            string newPassword = NewPasswordTB.Text;

            string errorMsg = UserController.validateChangePw(user.UserID, oldPassword, newPassword);
            if (errorMsg == "Update Password Successful!")
            {
                ErrorLbl2.Text = errorMsg;
                ErrorLbl2.ForeColor = System.Drawing.Color.Green;
                UserController.updateUserPassword(user.UserID, newPassword);
            }
            else
            {
                ErrorLbl2.Text = errorMsg;
                ErrorLbl2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}