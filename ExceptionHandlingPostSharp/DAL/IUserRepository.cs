using System.Collections.Generic;

namespace FP.Spartakiade2015.ExceptionHandlingPostSharp.DAL
{
    public interface IUserRepository
    {
        List<DOUser> GetAllUsers();

        DOUser GetUserById(int userId);

        void SaveUser(DOUser userToSave);

        void DeleteUser(int userId);
    }
}
