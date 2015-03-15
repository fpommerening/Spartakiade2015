using FP.Spartakiade2015.DurationNinject.DAL;

namespace BL
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
