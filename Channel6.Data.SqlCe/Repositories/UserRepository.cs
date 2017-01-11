using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Channel6.Model;

namespace Channel6.Data.SqlCe.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void Create(User user)
        {
            this.GetDbSet<User>().Add(user);
            this.UnitOfWork.SaveChanges();
        }

        public User GetUser(int userId)
        {
            return this.GetDbSet<User>()
                .Where(u => u.UserId == userId)
                .Single();
        }

        public IEnumerable<User> GetUsers()
        {
            return this.GetDbSet<User>()
                .ToList();
        }

        public void Update(User updatedUser)
        {
            User userToUpdate =
                this.GetDbSet<User>()
                        .Where(u => u.UserId == updatedUser.UserId)
                        .First();

            userToUpdate.Email = updatedUser.Email;
            userToUpdate.Password = updatedUser.Password;
            userToUpdate.Name = updatedUser.Name;
            userToUpdate.Country = updatedUser.Country;
            userToUpdate.Status = updatedUser.Status;
            userToUpdate.RegisterDateTime = updatedUser.RegisterDateTime;
            userToUpdate.LastLogin = updatedUser.LastLogin;

            this.SetEntityState(userToUpdate, userToUpdate.UserId == 0
                                                    ? EntityState.Added
                                                    : EntityState.Modified);
            this.UnitOfWork.SaveChanges();
    }

        public void Delete(int userId)
        {
            User user =
                this.GetDbSet<User>()
                    .Where(u => u.UserId == userId)
                    .Single();

            this.GetDbSet<User>().Remove(user);

            this.UnitOfWork.SaveChanges();
        }
    }
}
