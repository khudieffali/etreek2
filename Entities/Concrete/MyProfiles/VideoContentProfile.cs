using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class VideoContentProfile:Profile
    {
        public VideoContentProfile()
        {
            CreateMap<VideoContent, VideoContentDTO>()
          .ForMember(
              dest => dest.VideoPhoto,
              opt => opt.MapFrom(src => src.VideoPhoto)
              )
           .ForMember(
              dest => dest.VideoUrl,
              opt => opt.MapFrom(src => src.VideoUrl)
              )
            .ForMember(
              dest => dest.VideoPhoto,
              opt => opt.MapFrom(src => src.VideoPhoto)
              )
             .ForMember(
              dest => dest.Description,
              opt => opt.MapFrom(src => src.Description)
              )
             .ForMember(
              dest => dest.CourseId,
              opt => opt.MapFrom(src => src.CourseId)
              );
        }
    }
}
