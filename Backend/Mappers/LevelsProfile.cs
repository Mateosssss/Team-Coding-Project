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
    public class LevelsProfile : Profile
    {
        public LevelsProfile()
        {
            CreateMap<Levels, LevelsDto>()
                .ForMember(
                    dest => dest.ProjectId, 
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(
                    dest => dest.LevelNumber, 
                    opt => opt.MapFrom(src => src.LevelNumber))
                .ForMember(
                    dest => dest.TechnicalDescription, 
                    opt => opt.MapFrom(src => src.TechnicalDescription))
                .ForMember(
                    dest => dest.CableType, 
                    opt => opt.MapFrom(src => src.CableType))
                .ForMember(
                    dest => dest.LevelPlanFileAttachmentId, 
                    opt => opt.MapFrom(src => src.LevelPlanFileAttachmentId));
            CreateMap<CreateLevelsDto, Levels>()
                .ForMember(
                    dest => dest.ProjectId, 
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(
                    dest => dest.LevelNumber, 
                    opt => opt.MapFrom(src => src.LevelNumber))
                .ForMember(
                    dest => dest.TechnicalDescription, 
                    opt => opt.MapFrom(src => src.TechnicalDescription))
                .ForMember(
                    dest => dest.CableType, 
                    opt => opt.MapFrom(src => src.CableType))
                .ForMember(
                    dest => dest.LevelPlanFileAttachmentId, 
                    opt => opt.MapFrom(src => src.LevelPlanFileAttachmentId))
                .ForMember(
                    dest => dest.CreatedAt, 
                    opt => opt.MapFrom(src => src.CreatedAt));
        }
    }
}