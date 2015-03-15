using System;
using System.Collections.Generic;
using System.Linq;

namespace FP.Spartakiade2015.DurationNinject.DAL
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            Users = new List<DOUser>
            {
                new DOUser
                {
                    Id = 1,
                    Name = "Mustermann",
                    FirstName = "Max",
                    City = "Musterstadt",
                    Street = "Hauptstraße 17",
                    ZipCode = "12345"
                },
                new DOUser
                {
                    Id = 2,
                    Name = "Meier",
                    FirstName = "Sabine",
                    City = "Musterdorf",
                    Street = "Berlinstraße 42",
                    ZipCode = "98765"
                }
            };
        }

        private List<DOUser> Users { get; set; }

        public List<DOUser> GetAllUsers()
        {
            return Users;
        }

        public DOUser GetUserById(int userId)
        {
            if (userId % 2 == 0)
            {
                throw new Exception("Testfehler");
            }
            return Users.FirstOrDefault(x => x.Id == userId);
        }

        public void SaveUser(DOUser userToSave)
        {
            if (userToSave.Id <= 0)
            {
                userToSave.Id = Users.Max(x => x.Id) + 1;
            }
            Users.RemoveAll(x => x.Id == userToSave.Id);
            Users.Add(userToSave);
        }

        public void DeleteUser(int userId)
        {
            Users.RemoveAll(x => x.Id == userId);
        }
    }
}
