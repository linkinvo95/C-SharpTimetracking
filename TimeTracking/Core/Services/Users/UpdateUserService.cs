using BusinessEntities;
using Common;

namespace Core.Services.Users
{
    [AutoRegister]
    public class UpdateUserService : IUpdateUserService
    {
        public void Update(User user, string name, string email, UserTypes type)
        {
            user.SetName(name);
            user.SetEmail(email);
            user.SetType(type);
        }
    }
}