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
    public class AddonsProfile : Profile
    {
        public AddonsProfile()
        {
            CreateMap<Addons, AddonsDto>()
                .ForMember(
                    dest => dest.EntityType, 
                    opt => opt.MapFrom(src => src.EntityType))
                .ForMember(
                    dest => dest.EntityId, 
                    opt => opt.MapFrom(src => src.EntityId))
                .ForMember(
                    dest => dest.FileAttachmentId, 
                    opt => opt.MapFrom(src => src.FileAttachmentId))
                .ForMember(
                    dest => dest.UploadedByUserId, 
                    opt => opt.MapFrom(src => src.UploadedByUserId))
                .ForMember(
                    dest => dest.UploadedAt, 
                    opt => opt.MapFrom(src => src.UploadedAt));
            CreateMap<CreateAddonsDto, Addons>()
                .ForMember(
                    dest => dest.EntityType, 
                    opt => opt.MapFrom(src => src.EntityType))
                .ForMember(
                    dest => dest.EntityId, 
                    opt => opt.MapFrom(src => src.EntityId))
                .ForMember(
                    dest => dest.FileAttachmentId, 
                    opt => opt.MapFrom(src => src.FileAttachmentId))
                .ForMember(
                    dest => dest.UploadedByUserId, 
                    opt => opt.MapFrom(src => src.UploadedByUserId))
                .ForMember(
                    dest => dest.UploadedAt, 
                    opt => opt.MapFrom(src => src.UploadedAt));
        }
    }
}