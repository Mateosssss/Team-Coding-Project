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
    public class NetworkRacksProfile : Profile
    {
        public NetworkRacksProfile()
        {
            CreateMap<NetworkRack, NetworkRackDto>()
                .ForMember(
                    dest => dest.Model, opt => 
                    opt.MapFrom(src => src.Model))
                .ForMember(
                    dest => dest.Size, opt => 
                    opt.MapFrom(src => src.Size))
                .ForMember(
                    dest => dest.Location, opt => 
                    opt.MapFrom(src => src.Location))
                .ForMember(
                    dest => dest.FrontViewImageId, 
                    opt => opt.MapFrom(src => src.FrontViewImageId))
                .ForMember(
                    dest => dest.SideViewImageId, 
                    opt => opt.MapFrom(src => src.SideViewImageId))
                .ForMember(
                    dest => dest.RearViewImageId, 
                    opt => opt.MapFrom(src => src.RearViewImageId))
                .ForMember(
                    dest => dest.InstallationDate, 
                    opt => opt.MapFrom(src => src.InstallationDate));
            CreateMap<CreateNetworkRackDto, NetworkRack>()
                .ForMember(
                    dest => dest.ProjectId, 
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(
                    dest => dest.Model, 
                    opt => opt.MapFrom(src => src.Model))
                .ForMember(
                    dest => dest.Size, 
                    opt => opt.MapFrom(src => src.Size))
                .ForMember(
                    dest => dest.Location, 
                    opt => opt.MapFrom(src => src.Location))
                .ForMember(
                    dest => dest.FrontViewImageId, 
                    opt => opt.MapFrom(src => src.FrontViewImageId))
                .ForMember(
                    dest => dest.SideViewImageId, 
                    opt => opt.MapFrom(src => src.SideViewImageId))
                .ForMember(
                    dest => dest.RearViewImageId, 
                    opt => opt.MapFrom(src => src.RearViewImageId))
                .ForMember(
                    dest => dest.InstallationDate, 
                    opt => opt.MapFrom(src => src.InstallationDate));
        }
    }
}