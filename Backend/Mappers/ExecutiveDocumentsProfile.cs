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
    public class ExecutiveDocumentsProfile : Profile
    {
        public ExecutiveDocumentsProfile()
        {
            CreateMap<ExecutiveDocuments, ExecutiveDocumentsDto>()
                .ForMember(
                    dest => dest.ProjectId, 
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(
                    dest => dest.DocumentId, 
                    opt => opt.MapFrom(src => src.DocumentId))
                .ForMember(
                    dest => dest.UploadedAt, 
                    opt => opt.MapFrom(src => src.UploadedAt))
                .ForMember(
                    dest => dest.RecipientId, 
                    opt => opt.MapFrom(src => src.RecipientId));
            CreateMap<CreateExecutiveDocumentsDto, ExecutiveDocuments>()
                .ForMember(
                    dest => dest.ProjectId, 
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(
                    dest => dest.DocumentId, 
                    opt => opt.MapFrom(src => src.DocumentId))
                .ForMember(
                    dest => dest.UploadedAt, 
                    opt => opt.MapFrom(src => src.UploadedAt))
                .ForMember(
                    dest => dest.RecipientId, 
                    opt => opt.MapFrom(src => src.RecipientId));
        }
    }
}