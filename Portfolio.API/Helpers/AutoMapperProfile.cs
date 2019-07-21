using AutoMapper;
using Portfolio.API.Models;
using Portfolio.Core.Domain;
using System.Linq;

namespace Portfolio.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Image, ImageModel>()
                .ReverseMap();

            CreateMap<Technology, TechnologyModel>()
                .ReverseMap();

            CreateMap<Project, ProjectModel>()
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images.Select(pi => pi.Image)))
                .ForMember(dest => dest.Technologies, opt => opt.MapFrom(src => src.Technologies.Select(pt => pt.Technology)))
                .ReverseMap();
        }
    }
}