using FP.Spartakiade2015.ExceptionHandlingPostSharp.DAL;

namespace FP.Spartakiade2015.ExceptionHandlingPostSharp.BL
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
