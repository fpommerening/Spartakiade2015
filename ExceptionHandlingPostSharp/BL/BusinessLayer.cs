using System.Collections.Generic;
using System.Linq;
using FP.Spartakiade2015.ExceptionHandlingPostSharp.DAL;

namespace FP.Spartakiade2015.ExceptionHandlingPostSharp.BL
{
    public class BusinessLayer
    {
        private IUserRepository _userRepository; 

        public BusinessLayer(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<UserViewModel> GetAllUser()
        {
            try
            {
                var doUsers = _userRepository.GetAllUsers();
                return doUsers.Select(AutoMapper.Mapper.Map<UserViewModel>).ToList();
            }
            catch
            {
                return new List<UserViewModel>();
            }    
        }

        public UserViewModel GetUserById(int userId)
        {
            try
            {
                var doUser = _userRepository.GetUserById(userId);
                return AutoMapper.Mapper.Map<UserViewModel>(doUser);
            }
            catch
            {
                return null;
            }
        }
    }
}
