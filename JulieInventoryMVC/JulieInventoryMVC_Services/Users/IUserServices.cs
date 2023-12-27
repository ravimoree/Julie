using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JulieInventoryMVC_Models.Users;

namespace JulieInventoryMVC_Services.Users
{
    public interface IUserServices
    {
        int AddUser(UserMaster modal);
        UserMaster GetUser(string email);
    }
}
