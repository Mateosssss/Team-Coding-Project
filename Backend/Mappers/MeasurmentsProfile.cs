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
    public class MeasurmentsProfile : Profile
    {
        public MeasurmentsProfile()
        {
            CreateMap<Measurments, MeasurmentsDto>()
                .ForMember(
                    dest => dest.ServiceWorkerId, 
                    opt => opt.MapFrom(src => src.ServiceWorkerId))
                .ForMember(
                    dest => dest.AttachmentId, 
                    opt => opt.MapFrom(src => src.AttachmentId))
                .ForMember(
                    dest => dest.Type, opt => 
                    opt.MapFrom(src => src.Type))
                .ForMember(
                    dest => dest.TechnicalDetails, 
                    opt => opt.MapFrom(src => src.TechnicalDetails))
                .ForMember(
                    dest => dest.MeasuredAt, 
                    opt => opt.MapFrom(src => src.MeasuredAt))
                .ForMember(
                    dest => dest.Certification, 
                    opt => opt.MapFrom(src => src.Certification));
            CreateMap<CreateMeasurmentsDto, Measurments>()
                .ForMember(
                    dest => dest.OutletId, 
                    opt => opt.MapFrom(src => src.OutletId))
                .ForMember(
                    dest => dest.ServiceWorkerId, 
                    opt => opt.MapFrom(src => src.ServiceWorkerId))
                .ForMember(
                    dest => dest.AttachmentId, 
                    opt => opt.MapFrom(src => src.AttachmentId))
                .ForMember(
                    dest => dest.Type, 
                    opt => opt.MapFrom(src => src.Type))
                .ForMember(
                    dest => dest.TechnicalDetails, 
                    opt => opt.MapFrom(src => src.TechnicalDetails))
                .ForMember(
                    dest => dest.MeasuredAt, 
                    opt => opt.MapFrom(src => src.MeasuredAt))
                .ForMember(
                    dest => dest.Certification, 
                    opt => opt.MapFrom(src => src.Certification));
        }
    }
}