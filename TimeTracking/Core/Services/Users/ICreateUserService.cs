using System;
using BusinessEntities;

namespace Core.Services.Users
{
    public interface ICreateUserService
    {
        User Create(Guid id, string name, string email, UserTypes type);
    }
}