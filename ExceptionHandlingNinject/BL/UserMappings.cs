using FP.Spartakiade2015.ExceptionHandlingNinject.DAL;

namespace FP.Spartakiade2015.ExceptionHandlingNinject.BL
{
    public class UserMappings
    {
        public void CreateMapping()
        {
            AutoMapper.Mapper.CreateMap<DOUser, UserViewModel>();
            AutoMapper.Mapper.CreateMap<UserViewModel, DOUser>();
        }
    }
}
