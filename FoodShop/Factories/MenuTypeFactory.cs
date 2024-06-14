using FoodShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodShop.Factories
{
    public class MenuTypeFactory
    {
        public static MenuType Create(int typeID, String name)
        {
            MenuType type = new MenuType();
            type.MenuTypeID = typeID;
            type.MenuTypeName = name;
            return type;
        }
    }
}