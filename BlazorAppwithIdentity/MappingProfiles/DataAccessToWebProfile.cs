using AutoMapper;
using BlazorAppModels.Models;
using BlazorAppModels.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace BlazorAppwithIdentity.MappingProfiles
{
    public class DataAccessToWebProfile : Profile
    {
        public DataAccessToWebProfile()
        {
            CreateMap<ApplicationUser, UserVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.InitialPropertyValueSum, opt => opt.MapFrom(src => src.InitialPropertyValueSum))
                .ForMember(dest => dest.CurrentPropertyValueSum, opt => opt.MapFrom(src => src.CurrentPropertyValueSum))
                .ReverseMap()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email));  
        }
    }
}