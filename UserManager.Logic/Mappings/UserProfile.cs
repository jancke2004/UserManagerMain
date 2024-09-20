using AutoMapper;
using UserManager.Logic.DTOs.Users;
using UserManager.Repository.Models;

public class UserProfile : Profile
{
    public UserProfile()
    {
        // Create a map from AddUser DTO to Users entity
        CreateMap<AddUser, Users>()
            .ForMember(dest => dest.Date_Created, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.Date_Updated, opt => opt.MapFrom(src => DateTime.Now));
    }
}
