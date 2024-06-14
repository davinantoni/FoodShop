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
    public partial class ManageFood : System.Web.UI.Page
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
                        List<Model.Menu> menuList = MenuController.getAllMenus();
                        ManageMenu.DataSource = menuList;
                        ManageMenu.DataBind();

                        List<MenuType> menuTypeList = MenuTypeController.getAllMenuTypes();
                        MenuTypeGV.DataSource = menuTypeList;
                        MenuTypeGV.DataBind();

                        List<Restaurant> restaurantList = RestoController.getAllRestaurants();
                        RestaurantGV.DataSource = restaurantList;
                        RestaurantGV.DataBind();
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

        protected void ManageMenu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ManageMenu.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = MenuController.getMenuIDByName(name);
            MenuController.RemoveMenuById(id);
            List<Model.Menu> menuList = MenuController.getAllMenus();
            ManageMenu.DataSource = menuList;
            ManageMenu.DataBind();
        }

        protected void ManageMenu_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ManageMenu.Rows[e.NewEditIndex];
            String nameAwal = row.Cells[0].Text;

            //harus diginiin karena di kalo namenya ada petiknya dia returnnya malah gajelas
            String name = HttpUtility.HtmlDecode(nameAwal);
            //System.Diagnostics.Debug.WriteLine("Editing makeup with name: " + name);

            int id = MenuController.getMenuIDByName(name);
            Response.Redirect("~/Views/UpdateMenu.aspx?id=" + id);
        }

        protected void InsertMenuBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMenu.aspx");
        }

        protected void MenuTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Kalo kita hapus typeID 1, beraarti makeup yang punya id 1 juga ikut kehapus
            GridViewRow row = MenuTypeGV.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = MenuTypeController.getMenuTypeIDByName(name);
            MenuTypeController.RemoveMenuTypeById(id);
            List<MenuType> menuTypeList = MenuTypeController.getAllMenuTypes();
            MenuTypeGV.DataSource = menuTypeList;
            MenuTypeGV.DataBind();

            List<Model.Menu> menuList = MenuController.getAllMenus();
            ManageMenu.DataSource = menuList;
            ManageMenu.DataBind();
        }

        protected void MenuTypeGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MenuTypeGV.Rows[e.NewEditIndex];
            String name = row.Cells[0].Text;
            int id = MenuTypeController.getMenuTypeIDByName(name);
            Response.Redirect("~/Views/UpdateMenuType.aspx?id=" + id);
        }

        protected void InsertTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMenuType.aspx");
        }

        protected void RestaurantGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = RestaurantGV.Rows[e.RowIndex];
            String name = row.Cells[0].Text;
            int id = RestoController.getRestaurantIDByName(name);
            RestoController.RemoveRestaurantById(id);
            List<Restaurant> restoList = RestoController.getAllRestaurants();
            RestaurantGV.DataSource = restoList;
            RestaurantGV.DataBind();

            List<Model.Menu> menuList = MenuController.getAllMenus();
            ManageMenu.DataSource = menuList;
            ManageMenu.DataBind();
        }

        protected void RestaurantGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = RestaurantGV.Rows[e.NewEditIndex];
            String name = row.Cells[0].Text;
            int id = RestoController.getRestaurantIDByName(name);
            Response.Redirect("~/Views/UpdateRestaurant.aspx?id=" + id);
        }

        protected void InsertRestoBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertRestaurant.aspx");
        }
    }
}