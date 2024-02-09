using JulieInventoryMVC_Models.Users;

namespace JulieInventoryMVC_Services.Users
{
    public interface IUserServices
    {
        int AddUser(UserMaster modal);
        UserMaster GetUser(string email);
    }
}
