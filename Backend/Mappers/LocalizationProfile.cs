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
    public class LocalizationProfile : Profile
    {
        public LocalizationProfile()
        {
            CreateMap<Localization, LocalizationDto>()
                .ForMember(
                    dest => dest.Name, 
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Description, 
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Address, 
                    opt => opt.MapFrom(src => src.Address))
                .ForMember(
                    dest => dest.ContactEmail, 
                    opt => opt.MapFrom(src => src.ContactEmail))
                .ForMember(
                    dest => dest.ContactPhone, 
                    opt => opt.MapFrom(src => src.ContactPhone));
            CreateMap<CreateLocalizationDto, Localization>()
                .ForMember(
                    dest => dest.Name, 
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Description, 
                    opt => opt.MapFrom(src => src.Description))
                .ForMember(
                    dest => dest.Address, 
                    opt => opt.MapFrom(src => src.Address))
                .ForMember(
                    dest => dest.ContactEmail, 
                    opt => opt.MapFrom(src => src.ContactEmail))
                .ForMember(
                    dest => dest.ContactPhone, 
                    opt => opt.MapFrom(src => src.ContactPhone))
                .ForMember(
                    dest => dest.createdAt, 
                    opt => opt.Ignore());
        }
    }
}