
using AutoMapper;
using Microsoft.PowerBI.Api.Models;
using OtomasyonProject.WebUI.Dtos.LoginDto;
using OtomasyonProject.WebUI.Dtos.RegisterDto;

namespace OtomasyonProject.WebUI.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
