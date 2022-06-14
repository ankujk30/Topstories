using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopstoriesAPI.Model;
using TopstoriesAPI.Model.Dtos;

namespace TopstoriesAPI.TopstoriesMapper
{
    // This maping class is used to map the DTO to Model class and vice versa
    public class TopstoriesMapping : Profile
    {
        public TopstoriesMapping()
        {
            CreateMap<Root, RootDto>().ReverseMap();
            
            //We need to convert the string array to string to save the data in the databse. We are joining two array items using "**".
            CreateMap<Topstories, TopstoriesDto>().ReverseMap()
                .ForMember(dest => dest.Geo_facet, m => m.MapFrom(src => string.Join("**", src.Geo_facet)))
                .ForMember(dest => dest.Org_facet, m => m.MapFrom(src => string.Join("**", src.Org_facet)))
                .ForMember(dest => dest.Des_facet, m => m.MapFrom(src => string.Join("**", src.Des_facet)))
                .ForMember(dest => dest.Per_facet, m => m.MapFrom(src => string.Join("**", src.Per_facet)));

            CreateMap<Multimedium, MultimediumDto>().ReverseMap();
                
        }
    }
}
