using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JulieInventoryMVC.Models
{
    public class DBconnect
    {
        public static string connectionstring()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;
        }
    }
}