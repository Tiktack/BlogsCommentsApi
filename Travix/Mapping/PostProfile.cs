using AutoMapper;
using DataLayer.Entities;
using Travix.DTO;

namespace Travix.Mapping
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<InsertPostDTO, Post>();
            CreateMap<Post, ViewPostDTO>();
            CreateMap<EditPostDTO, Post>();
        }
    }
}
