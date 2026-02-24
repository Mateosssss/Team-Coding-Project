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
    public class RackPanelProfile:Profile
    {
        public RackPanelProfile()
        {
            CreateMap<RackPanel,RackPanelDto>()
                .ForMember(
                    dest=>dest.NetworkRackId,
                    opt=>opt.MapFrom(src=>src.NetworkRackId)
                ).ForMember(
                    dest=>dest.Type,
                    opt=>opt.MapFrom(src=>src.Type)
                ).ForMember(
                    dest=>dest.PortNumber,
                    opt=>opt.MapFrom(src=>src.PortNumber)
                ).ForMember(
                    dest=>dest.Position,
                    opt=>opt.MapFrom(src=>src.Position)
                );
            CreateMap<CreateRackPanelDto,RackPanel>().ForMember(
                    dest=>dest.NetworkRackId,
                    opt=>opt.MapFrom(src=>src.NetworkRackId)
                ).ForMember(
                    dest=>dest.Type,
                    opt=>opt.MapFrom(src=>src.Type)
                ).ForMember(
                    dest=>dest.PortNumber,
                    opt=>opt.MapFrom(src=>src.PortNumber)
                ).ForMember(
                    dest=>dest.Position,
                    opt=>opt.MapFrom(src=>src.Position)
                );
        }
    }
}