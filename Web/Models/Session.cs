using Kadmyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sakaryauni.Models
{
    public class DestekApp
    {
        public static User Login
        {
            get
            {
                if (HttpContext.Current.Session["User"] != null)
                    return (User)HttpContext.Current.Session["User"];
                else
                    return null;
            }
            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }
    }
}