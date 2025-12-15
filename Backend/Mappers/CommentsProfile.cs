using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Mappers
{
    public class CommentsProfile : Profile
    {
        public CommentsProfile()
        {
            CreateMap<Comments, CommentsDto>()
                .ForMember(
                    dest => dest.EntityType, 
                    opt => opt.MapFrom(src => src.EntityType)
                )
                .ForMember(
                    dest => dest.EntityId,
                     opt => opt.MapFrom(src => src.EntityId)
                )
                .ForMember(
                    dest => dest.AuthorId,
                     opt => opt.MapFrom(src => src.AuthorId)
                )
                .ForMember(
                    dest => dest.Content,
                    opt => opt.MapFrom(src => src.Content)
                )
                .ForMember(
                    dest => dest.Status, 
                    opt => opt.MapFrom(src => src.Status)
                )
                .ForMember(
                    dest => dest.CreatedAt, 
                    opt => opt.MapFrom(src => src.CreatedAt)
                );
            CreateMap<CreateCommentsDto, Comments>()
                .ForMember(
                    dest => dest.EntityType,
                    opt => opt.MapFrom(src => src.EntityType)
                )
                .ForMember(
                    dest => dest.EntityId,
                    opt => opt.MapFrom(src => src.EntityId)
                )
                .ForMember(
                    dest => dest.AuthorId,
                    opt => opt.MapFrom(src => src.AuthorId)
                )
                .ForMember(
                    dest => dest.Content, 
                    opt => opt.MapFrom(src => src.Content)
                )
                .ForMember(
                    dest => dest.Status, 
                    opt => opt.MapFrom(src => src.Status)
                )
                .ForMember(
                    dest => dest.CreatedAt, 
                    opt => opt.MapFrom(src => src.CreatedAt)
                );
        }
    }
}