using System.Collections.Generic;
using Channel6.Model;

namespace Channel6.Data
{
    public interface IUserRepository
    {
        void Create(User user);
        User GetUser(int userId);
        IEnumerable<User> GetUsers();
        void Update(User user);
        void Delete(int userId);
    }
}
